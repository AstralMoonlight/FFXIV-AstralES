using System.Runtime.InteropServices;
using AstralES.Translation;
using Dalamud.Game.Addon.Lifecycle;
using Dalamud.Game.Addon.Lifecycle.AddonArgTypes;
using Dalamud.Game.Command;
using Dalamud.Hooking;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using Dalamud.Utility;
using FFXIVClientStructs.FFXIV.Component.GUI;
using Lumina.Text.ReadOnly;

namespace AstralES;

/// <summary>
/// Translates two of the game's tooltips before they lay themselves out, so the game measures
/// the Spanish itself and heights and positions come out right with no layout code here:
/// <list type="bullet">
/// <item>ActionDetail (actions and traits): its string array, in PreRequestedUpdate. Rewriting the
/// text nodes afterwards (the first version) left the nodes below the
/// description where the English put them, and a longer Spanish line ran over "Acquired".</item>
/// <item>The plain text tooltip (statuses and most UI hints): the text handed to
/// AtkTooltipManager.ShowTooltip, swapped before the original runs.</item>
/// </list>
/// No entry is addressed by index: every string goes through <see cref="Spanish.Macro"/> and only
/// lines it knows change, so names and labels stay as the game wrote them.
/// </summary>
public sealed unsafe class Plugin : IDalamudPlugin
{
    private const string AddonName = "ActionDetail";
    private const string Command = "/astrales";

    private delegate void ShowTooltipDelegate(
        AtkTooltipManager* manager, AtkTooltipType type, ushort parentId, AtkResNode* targetNode,
        AtkTooltipManager.AtkTooltipArgs* args, nint unkDelegate, byte unk7, byte unk8);

    private readonly IAddonLifecycle lifecycle;
    private readonly ICommandManager commands;
    private readonly IChatGui chat;
    private readonly IPluginLog log;
    private readonly Hook<ShowTooltipDelegate> showTooltip;
    private readonly Msq msq;
    private readonly AddonText addonText;

    // Each unknown line is logged once, so /xllog lists exactly what is left to translate.
    private readonly HashSet<string> reported = [];

    // Text this plugin wrote. If the array still holds it on the next update, it is skipped.
    private readonly HashSet<string> written = [];

    // Spanish tooltip texts in native memory, one per distinct text. Never freed: the game may still
    // point at one after this plugin unloads, and a freed one would crash it.
    // ponytail: grows with each distinct tooltip text seen (a few KB per session); add an LRU if that ever matters.
    private readonly Dictionary<string, nint> nativeTexts = [];

    private bool enabled = true;
    private bool diagnostics;

    public Plugin(IAddonLifecycle lifecycle, ICommandManager commands, IChatGui chat, IPluginLog log, IGameInteropProvider interop,
        IClientState clientState, IDataManager data, ISeStringEvaluator evaluator)
    {
        this.lifecycle = lifecycle;
        this.commands = commands;
        this.chat = chat;
        this.log = log;

        lifecycle.RegisterListener(AddonEvent.PreRequestedUpdate, AddonName, OnUpdate);
        lifecycle.RegisterListener(AddonEvent.PostRequestedUpdate, AddonName, OnDrawn);

        showTooltip = interop.HookFromAddress<ShowTooltipDelegate>(
            (nint)AtkTooltipManager.MemberFunctionPointers.ShowTooltip, OnShowTooltip);
        showTooltip.Enable();

        addonText = new AddonText(interop, lifecycle, data, log, () => enabled, () => diagnostics);
        msq = new Msq(lifecycle, clientState, data, evaluator, log, () => enabled, () => diagnostics);

        commands.AddHandler(Command, new CommandInfo(OnCommand)
        {
            HelpMessage = "Activa o desactiva la traducción. \"/astrales diag\" activa o desactiva el diagnóstico en /xllog.",
        });
    }

    private void OnCommand(string command, string args)
    {
        if (args.Trim() == "diag")
        {
            diagnostics = !diagnostics;
            chat.Print($"[AstralES] Diagnóstico {(diagnostics ? "activado: pasa el mouse por habilidades y estados o habla con alguien, y revisa /xllog" : "desactivado")}.");
            return;
        }

        enabled = !enabled;
        chat.Print($"[AstralES] Traducción {(enabled ? "activada" : "desactivada")}. Vuelve a abrir el tooltip para verlo.");
    }

    private void OnUpdate(AddonEvent type, AddonArgs args)
    {
        if (!enabled)
            return;

        try
        {
            Apply(AtkStage.Instance()->GetStringArrayData(StringArrayType.ActionDetail));
        }
        catch (Exception ex)
        {
            // Runs on every update while the box is open: a throw would repeat forever, so stop instead.
            enabled = false;
            log.Error(ex, "Tooltip translation stopped after an error");
        }
    }

    private void Apply(StringArrayData* strings)
    {
        if (strings is null)
            return;

        for (var i = 0; i < strings->Size; i++)
        {
            var value = strings->StringArray[i];

            if (value.Value is null)
                continue;

            if (diagnostics)
                Diagnose($"ActionDetail[{i}]", value.AsReadOnlySeStringSpan().ToMacroString());

            var translated = Translate(value.AsReadOnlySeStringSpan());

            if (translated is null)
                continue;

            // managed: the array keeps its own copy; suppressUpdates: we are already inside the update.
            strings->SetValue(i, ReadOnlySeString.FromMacroString(translated, default).Data.Span, false, true, true);
            written.Add(translated);
        }
    }

    private void OnShowTooltip(
        AtkTooltipManager* manager, AtkTooltipType type, ushort parentId, AtkResNode* targetNode,
        AtkTooltipManager.AtkTooltipArgs* args, nint unkDelegate, byte unk7, byte unk8)
    {
        try
        {
            if (enabled && args is not null && type.HasFlag(AtkTooltipType.Text) && args->TextArgs.Text.Value is not null)
            {
                var text = args->TextArgs.Text.AsReadOnlySeStringSpan();

                if (diagnostics)
                    Diagnose($"Tooltip({type})", text.ToMacroString());

                if (Translate(text) is { } translated)
                    args->TextArgs.Text = (byte*)Native(translated);
            }
        }
        catch (Exception ex)
        {
            // Never let a tooltip take the game down: log once and carry on untranslated.
            if (reported.Add("tooltip-error"))
                log.Error(ex, "Text tooltip translation failed");
        }

        showTooltip.Original(manager, type, parentId, targetNode, args, unkDelegate, unk7, unk8);
    }

    /// <summary>The Spanish macro text, or null when nothing in it changes.</summary>
    private string? Translate(ReadOnlySeStringSpan seString)
    {
        // Macro form keeps the colour tags (<colortype(504)>…) so the Spanish can carry them too.
        var macro = seString.ToMacroString();

        if (string.IsNullOrWhiteSpace(macro) || written.Contains(macro))
            return null;

        var plain = seString.ExtractText().Replace("\r\n", "\n").Replace('\r', '\n');
        ReportUnknown(plain);

        var dropped = new List<string>();
        var translated = Spanish.Macro(macro, dropped);

        foreach (var tag in dropped)
        {
            if (reported.Add(tag))
                log.Info($"Tag no reconocido (se omitió): {tag}  en: {macro}");
        }

        if (translated != macro)
            return translated;

        // Known as plain text but nothing changed in macro form: the macro is shaped in a way
        // Spanish.Macro does not expect. Log it once, verbatim, so it can be handled.
        if (Spanish.Text(plain) != plain && reported.Add(macro))
            log.Info($"Reconocido pero sin aplicar: {macro}");

        return null;
    }

    private nint Native(string macro)
    {
        if (nativeTexts.TryGetValue(macro, out var pointer))
            return pointer;

        var bytes = ReadOnlySeString.FromMacroString(macro, default).Data.Span;
        pointer = Marshal.AllocHGlobal(bytes.Length + 1);
        bytes.CopyTo(new Span<byte>((void*)pointer, bytes.Length));
        ((byte*)pointer)[bytes.Length] = 0;

        nativeTexts[macro] = pointer;
        written.Add(macro);
        return pointer;
    }

    // Diagnostics only: every text node of the finished box, which shows the labels that come from
    // the window's own layout rather than from the string array.
    private void OnDrawn(AddonEvent type, AddonArgs args)
    {
        if (!diagnostics)
            return;

        var addon = (AtkUnitBase*)args.Addon.Address;

        for (var i = 0; addon is not null && i < addon->UldManager.NodeListCount; i++)
        {
            var node = addon->UldManager.NodeList[i];

            if (node is not null && node->Type == NodeType.Text)
                Diagnose($"ActionDetail nodo {node->NodeId}", ((AtkTextNode*)node)->NodeText.ToString());
        }
    }

    private void Diagnose(string where, string text)
    {
        if (reported.Add($"diag|{where}|{text}"))
            log.Info($"[diag] {where}: {text}");
    }

    // Only multi-line blocks are descriptions; single lines are names, labels and numbers.
    private void ReportUnknown(string text)
    {
        if (!text.Contains('\n'))
            return;

        foreach (var line in text.Split('\n'))
        {
            if (line.Trim().Length > 0 && Spanish.Line(line) is null && reported.Add(Spanish.Template(line)))
                log.Info($"Sin traducir: {Spanish.Template(line)}");
        }
    }

    public void Dispose()
    {
        showTooltip.Dispose();
        msq.Dispose();
        addonText.Dispose();
        lifecycle.UnregisterListener(OnUpdate, OnDrawn);
        commands.RemoveHandler(Command);
    }
}
