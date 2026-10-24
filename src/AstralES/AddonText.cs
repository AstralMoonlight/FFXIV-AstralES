using System.Reflection;
using System.Runtime.InteropServices;
using Dalamud.Game;
using Dalamud.Game.Addon.Lifecycle;
using Dalamud.Game.Addon.Lifecycle.AddonArgTypes;
using Dalamud.Hooking;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.UI.Misc;
using FFXIVClientStructs.FFXIV.Component.GUI;
using Lumina.Excel;
using Dalamud.Utility;
using Lumina.Text.ReadOnly;

namespace AstralES;

/// <summary>
/// Interface text (the Addon sheet: window titles, buttons, labels, confirmations) in Spanish at
/// the source: the game asks <c>RaptureTextModule.GetAddonText</c> for a row and gets the Spanish
/// row back, macros and all, so it fills in its own numbers and names afterwards. Works before
/// login too (title screen, character select).
/// <para>
/// The fixed labels a window's layout (ULD) carries are resolved by the game without that call:
/// each text node keeps its Addon row in <c>TextId</c>. Those are swapped once the window is set up,
/// and again whenever it refreshes or receives an event (a tab not shown at setup, like Sound
/// Settings, fills its labels later), only while the node still shows that row's English. The label
/// of a button, checkbox, radio button or dropdown comes from the component's own data, in a node
/// with no <c>TextId</c>: there it is matched by its English text (rows without macros only). Only
/// there, so an action name that matches a translated word ("Fire" in Actions &amp; Traits) stays.
/// </para>
/// <para>
/// msq/addon/NN-Addon.tsv holds each distinct English text once, under its first row; every row
/// with the same English gets the same Spanish.
/// </para>
/// </summary>
public sealed unsafe class AddonText : IDisposable
{
    private delegate byte* GetAddonTextDelegate(RaptureTextModule* module, uint id);

    private readonly Hook<GetAddonTextDelegate> hook;
    private readonly IAddonLifecycle lifecycle;
    private readonly IPluginLog log;
    private readonly Func<bool> enabled;
    private readonly Func<bool> diagnostics;
    private bool failed;

    // Each window logs its count once, so /xllog shows which windows the labels reach.
    private readonly HashSet<string> logged = [];
    private readonly HashSet<string> diagnosed = [];

    // Row → Spanish bytes in native memory. Never freed: the game keeps the pointers it was given.
    private readonly Dictionary<uint, nint> rows = [];

    // Row → its English as plain text, to tell a layout label from text the window set itself.
    private readonly Dictionary<uint, string> english = [];

    // English text of a macro-free row → its Spanish, for component labels.
    private readonly Dictionary<string, nint> byText = [];

    public AddonText(IGameInteropProvider interop, IAddonLifecycle lifecycle, IDataManager data, IPluginLog log, Func<bool> enabled, Func<bool> diagnostics)
    {
        this.diagnostics = diagnostics;
        this.lifecycle = lifecycle;
        this.log = log;
        this.enabled = enabled;

        var sheet = data.GetExcelSheet<RawRow>(ClientLanguage.English, "Addon");
        var spanish = new Dictionary<string, string>();
        var assembly = Assembly.GetExecutingAssembly();

        foreach (var resource in assembly.GetManifestResourceNames().Where(n => n.StartsWith("addon.") && n.EndsWith("-Addon.tsv")))
        {
            using var reader = new StreamReader(assembly.GetManifestResourceStream(resource)!);

            foreach (var line in reader.ReadToEnd().Split('\n').Skip(1))
            {
                // TEXT_ADDON_<row> → the English of that row, as the extractor wrote it.
                if (line.TrimEnd('\r').Split('\t') is [var key, var es] && uint.TryParse(key["TEXT_ADDON_".Length..], out var row)
                    && sheet.HasRow(row))
                    spanish.TryAdd(English(sheet.GetRow(row)), es);
            }
        }

        foreach (var row in sheet)
        {
            if (!spanish.TryGetValue(English(row), out var es))
                continue;

            var bytes = ReadOnlySeString.FromMacroString(es, default).Data.Span;
            var pointer = Marshal.AllocHGlobal(bytes.Length + 1);
            bytes.CopyTo(new Span<byte>((void*)pointer, bytes.Length));
            ((byte*)pointer)[bytes.Length] = 0;
            rows[row.RowId] = pointer;
            english[row.RowId] = row.ReadStringColumn(0).ExtractText();

            if (!English(row).Contains('<'))
                byText.TryAdd(english[row.RowId], pointer);
        }

        log.Info($"Addon: {rows.Count} filas en español");

        hook = interop.HookFromAddress<GetAddonTextDelegate>((nint)RaptureTextModule.MemberFunctionPointers.GetAddonText, Detour);
        hook.Enable();
        lifecycle.RegisterListener(AddonEvent.PostSetup, OnSetup);
        lifecycle.RegisterListener(AddonEvent.PostRefresh, OnSetup);
        lifecycle.RegisterListener(AddonEvent.PostRequestedUpdate, OnSetup);
        lifecycle.RegisterListener(AddonEvent.PostReceiveEvent, OnSetup);
    }

    private void OnSetup(AddonEvent type, AddonArgs args)
    {
        if (!enabled() || failed)
            return;

        try
        {
            var addon = (AtkUnitBase*)args.Addon.Address;

            if (addon is null)
                return;

            var swapped = Swap(&addon->UldManager, 0, false, args.AddonName);

            if (type == AddonEvent.PostSetup && logged.Add(args.AddonName))
                log.Info($"Addon: {args.AddonName}, {swapped} etiquetas en español");
        }
        catch (Exception ex)
        {
            // Runs for every window: stop rather than log the same failure forever.
            failed = true;
            log.Error(ex, "Addon label translation stopped after an error");
        }
    }

    private int Swap(AtkUldManager* uld, int depth, bool label, string addonName)
    {
        var swapped = 0;

        for (var i = 0; i < uld->NodeListCount; i++)
        {
            var node = uld->NodeList[i];

            if (node is null)
                continue;

            if (node->Type == NodeType.Text)
            {
                var text = (AtkTextNode*)node;
                var known = text->TextId != 0 && rows.ContainsKey(text->TextId);

                // Runs on every event: read the text only where it can matter.
                if (!known && !label && !diagnostics())
                    continue;

                var current = text->NodeText.StringPtr.AsReadOnlySeStringSpan().ExtractText();

                if (known && current == english[text->TextId])
                {
                    text->SetText((byte*)rows[text->TextId]);
                    swapped++;
                }
                else if (label && text->TextId == 0 && byText.TryGetValue(current, out var pointer))
                {
                    text->SetText((byte*)pointer);
                    swapped++;
                }
                // What stays in English, and why: no row, another sheet, or text the window set itself.
                else if (diagnostics() && current.Any(char.IsAsciiLetter)
                    && diagnosed.Add($"{addonName}|{node->NodeId}|{current}"))
                {
                    log.Info($"[diag] {addonName} nodo {node->NodeId}: TextId={text->TextId} hoja={text->SheetType} \"{current}\"");
                }
            }
            // Buttons, tabs and checkboxes are components with their own nodes.
            else if ((ushort)node->Type >= 1000 && depth < 8 && ((AtkComponentNode*)node)->Component is not null)
            {
                var component = ((AtkComponentNode*)node)->Component;
                var isLabel = component->GetComponentType() is ComponentType.Button or ComponentType.CheckBox
                    or ComponentType.RadioButton or ComponentType.DropDownList or ComponentType.HoldButton;
                swapped += Swap(&component->UldManager, depth + 1, isLabel, addonName);
            }
        }

        return swapped;
    }

    private static string English(RawRow row) => row.ReadStringColumn(0).ToMacroString().Replace("\r", "").Replace("\n", "<br>");

    private byte* Detour(RaptureTextModule* module, uint id) =>
        enabled() && rows.TryGetValue(id, out var pointer) ? (byte*)pointer : hook.Original(module, id);

    public void Dispose()
    {
        lifecycle.UnregisterListener(OnSetup);
        hook.Dispose();
    }
}
