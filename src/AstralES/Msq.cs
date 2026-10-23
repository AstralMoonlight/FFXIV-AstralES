using System.Reflection;
using System.Text.RegularExpressions;
using Dalamud.Game;
using Dalamud.Game.Addon.Lifecycle;
using Dalamud.Game.Addon.Lifecycle.AddonArgTypes;
using Dalamud.Plugin.Services;
using Dalamud.Utility;
using FFXIVClientStructs.FFXIV.Component.GUI;
using Lumina.Excel;
using Lumina.Text.ReadOnly;

namespace AstralES;

/// <summary>
/// Main scenario text (msq/es, embedded): swaps the strings any window receives, before it lays
/// itself out, the same way the action tooltip is handled.
/// <para>
/// The windows get the text already resolved (the character's name, the gender variant), so a line
/// is recognised by its resolved English: for every translated key, the English row of that key is
/// read from the game and both it and the Spanish are evaluated for the current character. The
/// table is built on first use after login and rebuilt on the next login.
/// </para>
/// </summary>
public sealed unsafe class Msq : IDisposable
{
    // Windows whose leftover English is worth reporting; every other window is still translated.
    private static readonly string[] Dialogue = ["Talk", "TalkSubtitle"];

    // "(-Grizzled Passenger-)Hello" shows "Grizzled Passenger" as the speaker and "Hello" as the line.
    // The duty list and the journal read their text from the game's global string arrays, not from
    // their AtkValues: those arrays are translated just before the window updates from them.
    private static readonly Dictionary<string, StringArrayType> Arrays = new()
    {
        ["_ToDoList"] = StringArrayType.ToDoList,
        ["Journal"] = StringArrayType.Journal,
        ["JournalDetail"] = StringArrayType.Journal,
    };

    private static readonly Regex SpeakerPrefix = new(@"^\(-(.*?)-\)", RegexOptions.Compiled);
    private static readonly Regex Counter = new(@"\s+\d+/\d+$", RegexOptions.Compiled);

    private readonly IAddonLifecycle lifecycle;
    private readonly IClientState clientState;
    private readonly IDataManager data;
    private readonly ISeStringEvaluator evaluator;
    private readonly IPluginLog log;
    private readonly Func<bool> enabled;
    private readonly Func<bool> diagnostics;

    // Resolved English (plain, normalised) → resolved Spanish. Speaker labels go in the same table.
    private Dictionary<string, ReadOnlySeString>? table;
    private readonly HashSet<string> reported = [];

    // Spanish already written into a subtitle node: the next frame finds it there and must not report it.
    private readonly HashSet<string> drawn = [];

    public Msq(IAddonLifecycle lifecycle, IClientState clientState, IDataManager data, ISeStringEvaluator evaluator,
        IPluginLog log, Func<bool> enabled, Func<bool> diagnostics)
    {
        this.lifecycle = lifecycle;
        this.clientState = clientState;
        this.data = data;
        this.evaluator = evaluator;
        this.log = log;
        this.enabled = enabled;
        this.diagnostics = diagnostics;

        // Every window: a line is recognised by its text, not by where it shows up, so the cutscene
        // subtitles, the answer lists and whatever else carries quest text are all covered.
        lifecycle.RegisterListener(AddonEvent.PreSetup, OnAddon);
        lifecycle.RegisterListener(AddonEvent.PreRefresh, OnAddon);
        lifecycle.RegisterListener(AddonEvent.PreDraw, ["TalkSubtitle", "_BattleTalk"], OnSubtitleDraw);
        lifecycle.RegisterListener(AddonEvent.PreRequestedUpdate, Arrays.Keys, OnArrayUpdate);
        clientState.Login += Reset;
    }

    private void Reset() => table = null;

    private void OnAddon(AddonEvent type, AddonArgs args)
    {
        if (!enabled() || !clientState.IsLoggedIn)
            return;

        try
        {
            var (address, count) = args switch
            {
                AddonSetupArgs s => (s.AtkValues, s.AtkValueCount),
                AddonRefreshArgs r => (r.AtkValues, r.AtkValueCount),
                _ => (nint.Zero, 0u),
            };

            if (address == nint.Zero)
                return;

            var values = (AtkValue*)address;

            table ??= Build();

            for (var i = 0; i < count; i++)
            {
                var value = &values[i];

                if (value->Type is not (AtkValueType.String or AtkValueType.ManagedString or AtkValueType.ConstString)
                    || !value->String.HasValue)
                    continue;

                var text = value->String.AsReadOnlySeStringSpan();
                var plain = Normalize(text.ExtractText());

                if (plain.Length == 0)
                    continue;

                if (diagnostics() && plain.Any(char.IsLetter))
                    Report($"[diag] {args.AddonName}[{i}]: {text.ToMacroString()}");

                if (table.TryGetValue(plain, out var spanish))
                {
                    // A trailing 0 in case the copy is taken as a C string.
                    value->SetManagedString([.. spanish.Data.Span, 0]);
                }
                else if (Dialogue.Contains(args.AddonName) && plain.Length > 20)
                {
                    Report($"Sin traducir (MSQ): {plain}");
                }
            }
        }
        catch (Exception ex)
        {
            // A dialogue box must never take the game down: log once and leave it in English.
            if (reported.Add("msq-error"))
                log.Error(ex, "MSQ translation failed");
        }
    }

    private void OnArrayUpdate(AddonEvent type, AddonArgs args)
    {
        if (!enabled() || !clientState.IsLoggedIn)
            return;

        try
        {
            var strings = AtkStage.Instance()->GetStringArrayData(Arrays[args.AddonName]);
            table ??= Build();

            for (var i = 0; strings is not null && i < strings->Size; i++)
            {
                var value = strings->StringArray[i];

                if (value.Value is null)
                    continue;

                var text = value.AsReadOnlySeStringSpan().ExtractText();
                var plain = Normalize(text);

                if (diagnostics() && plain.Any(char.IsLetter))
                    Report($"[diag] {args.AddonName} arreglo[{i}]: {value.AsReadOnlySeStringSpan().ToMacroString()}");

                // managed: the array keeps its own copy; suppressUpdates: we are already inside the update.
                if (table.TryGetValue(plain, out var spanish))
                    strings->SetValue(i, spanish.Data.Span, false, true, true);
                // Kill objectives carry their count in the same string: "Slay ground squirrels. 0/3".
                else if (Counter.Match(text) is { Success: true } counter && table.TryGetValue(Normalize(text[..counter.Index]), out spanish))
                    strings->SetValue(i, ReadOnlySeString.FromMacroString(spanish.ToMacroString() + counter.Value).Data.Span, false, true, true);
            }
        }
        catch (Exception ex)
        {
            if (reported.Add("array-error"))
                log.Error(ex, "Duty list / journal translation failed");
        }
    }

    // The opening's "Hear... Feel... Think..." shows in TalkSubtitle, and the lines spoken mid-fight
    // ("Well done! We're almost there!") in _BattleTalk, which gets its text from
    // UIModule.ShowBattleTalk, not from its values. Both are swapped here in their text nodes, just before drawing.
    // ponytail: rewrites the node after layout (a longer line is not re-centred); drop this once
    // the diagnostics show the text arriving in AtkValues.
    private void OnSubtitleDraw(AddonEvent type, AddonArgs args)
    {
        if (!enabled() || table is null)
            return;

        try
        {
            var addon = (AtkUnitBase*)args.Addon.Address;

            for (var i = 0; addon is not null && i < addon->UldManager.NodeListCount; i++)
            {
                var node = addon->UldManager.NodeList[i];

                if (node is null || node->Type != NodeType.Text)
                    continue;

                var textNode = (AtkTextNode*)node;
                var plain = Normalize(textNode->NodeText.StringPtr.AsReadOnlySeStringSpan().ExtractText());

                if (plain.Length == 0)
                    continue;

                if (diagnostics())
                    Report($"[diag] {args.AddonName} nodo {node->NodeId}: {plain}");

                if (table.TryGetValue(plain, out var spanish))
                {
                    textNode->SetText([.. spanish.Data.Span, 0]);
                    drawn.Add(Normalize(spanish.ExtractText()));
                }
                // Battle lines from a sheet not loaded yet (neither quest nor duty text) show up here.
                else if (plain.Length > 20 && !drawn.Contains(plain))
                    Report($"Sin traducir ({args.AddonName}): {plain}");
            }
        }
        catch (Exception ex)
        {
            if (reported.Add("subtitle-error"))
                log.Error(ex, "Subtitle translation failed");
        }
    }

    // ponytail: evaluates every translated line at once (a few hundred today); build per quest on
    // demand once the table reaches tens of thousands of lines and login gets slow.
    private Dictionary<string, ReadOnlySeString> Build()
    {
        var result = new Dictionary<string, ReadOnlySeString>();
        var assembly = Assembly.GetExecutingAssembly();
        var lines = 0;
        Dictionary<string, ReadOnlySeString>? dutyRows = null;

        foreach (var resource in assembly.GetManifestResourceNames().Where(n => n.StartsWith("msq.")))
        {
            var sheet = SheetOf(resource);

            // Quest and cutscene sheets carry their key in column 0; a duty's battle lines are
            // InstanceContentTextData rows, keyed TEXT_DUTY<duty>_<row> by the extractor.
            var duty = sheet == "InstanceContentTextData";
            var english = duty
                ? dutyRows ??= data.GetExcelSheet<RawRow>(ClientLanguage.English, sheet)
                    .ToDictionary(r => r.RowId.ToString(), r => r.ReadStringColumn(0))
                : data.GetExcelSheet<RawRow>(ClientLanguage.English, sheet)
                    .ToDictionary(r => r.ReadStringColumn(0).ExtractText(), r => r.ReadStringColumn(1));

            using var reader = new StreamReader(assembly.GetManifestResourceStream(resource)!);

            foreach (var line in reader.ReadToEnd().Split('\n').Skip(1))
            {
                var parts = line.TrimEnd('\r').Split('\t');

                if (parts.Length != 2 || !english.TryGetValue(duty ? parts[0][DutyPrefix(resource).Length..] : parts[0], out var en))
                    continue;

                var enText = evaluator.Evaluate(en, [], ClientLanguage.English).ExtractText();
                var esMacro = parts[1];

                // The speaker label travels apart from the line: translate both, without the prefix.
                if (SpeakerPrefix.Match(enText) is { Success: true } enSpeaker && SpeakerPrefix.Match(esMacro) is { Success: true } esSpeaker)
                {
                    result.TryAdd(Normalize(enSpeaker.Groups[1].Value), evaluator.EvaluateMacroString(esSpeaker.Groups[1].Value, [], ClientLanguage.English));
                    enText = enText[enSpeaker.Length..];
                    esMacro = esMacro[esSpeaker.Length..];
                }

                result.TryAdd(Normalize(enText), evaluator.EvaluateMacroString(esMacro, [], ClientLanguage.English));
                lines++;
            }
        }

        // Generic NPCs ("Carriage Driver") name the speaker from their own row, not from the line.
        using (var npc = new StreamReader(assembly.GetManifestResourceStream("npc.tsv")!))
        {
            foreach (var line in npc.ReadToEnd().Split('\n').Skip(1))
            {
                if (line.TrimEnd('\r').Split('\t') is [var en, var es])
                    result.TryAdd(Normalize(en), evaluator.EvaluateMacroString(es, [], ClientLanguage.English));
            }
        }

        log.Info($"MSQ: {lines} líneas en español listas para este personaje");
        return result;
    }

    // "msq.0001-ManFst000_00083.tsv" → quest/000/ManFst000_00083; "msq.VoiceMan_03200.tsv" → cut_scene/032/VoiceMan_03200;
    // "msq.OpeningGridania.tsv" → opening/OpeningGridania; "msq.30111-Duty30111.tsv" → InstanceContentTextData;
    // "msq.03-FesHlx2026Guide_00977.tsv" → custom/009/FesHlx2026Guide_00977 (a quest id is always like FesHlx201_05467);
    // "msq.Aetheryte.tsv" → transport/Aetheryte (no "_" in the id).
    private static string SheetOf(string resource)
    {
        var id = IdOf(resource);
        return id.StartsWith("VoiceMan_") ? $"cut_scene/{id[^5..^2]}/{id}"
            : id.StartsWith("Opening") ? $"opening/{id}"
            : id.StartsWith("Duty") ? "InstanceContentTextData"
            : !id.Contains('_') ? $"transport/{id}"
            : Regex.IsMatch(id, @"^[A-Za-z]{6}\d{3}_\d{5}$") ? $"quest/{id[^5..^2]}/{id}"
            : $"custom/{id[^5..^2]}/{id}";
    }

    private static string IdOf(string resource)
    {
        var id = resource["msq.".Length..^".tsv".Length];
        return id[(id.IndexOf('-') + 1)..];
    }

    // "msq.30111-Duty30111.tsv" → TEXT_DUTY30111_
    private static string DutyPrefix(string resource) => $"TEXT_{IdOf(resource).ToUpperInvariant()}_";

    // The window may wrap or break lines differently from the sheet: compare words only.
    private static string Normalize(string text) => string.Join(' ', text.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries));

    private void Report(string message)
    {
        if (reported.Add(message))
            log.Info(message);
    }

    public void Dispose()
    {
        lifecycle.UnregisterListener(OnAddon, OnSubtitleDraw, OnArrayUpdate);
        clientState.Login -= Reset;
    }
}
