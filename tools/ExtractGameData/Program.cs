// Reads the installed game's Excel sheets (English) and writes every combat class/job, its
// actions and its traits — with the game's own numbers and original text — as a C# file.
//
//     dotnet run --project tools/ExtractGameData -- [sqpack path] [output path]
//
// Re-run after every patch. Nothing here is typed by hand.

using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Lumina;
using Lumina.Data;
using Lumina.Excel.Sheets;
using LuminaAction = Lumina.Excel.Sheets.Action;

const string DefaultSqpack = @"D:\SteamLibrary\steamapps\common\FINAL FANTASY XIV Online\game\sqpack";

var sqpack = args.Length > 0 ? args[0] : DefaultSqpack;
var output = args.Length > 1
    ? args[1]
    : Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..",
        "src", "AstralES", "Data", "GameData.g.cs");

if (!Directory.Exists(sqpack))
{
    Console.Error.WriteLine($"no sqpack folder at: {sqpack}");
    return 1;
}

var data = new GameData(sqpack, new LuminaOptions { DefaultExcelLanguage = Language.English });
var classSheet = data.GetExcelSheet<ClassJob>()!;
var actionSheet = data.GetExcelSheet<LuminaAction>()!;
var actionTransient = data.GetExcelSheet<ActionTransient>()!;
var traitSheet = data.GetExcelSheet<Trait>()!;
var traitTransient = data.GetExcelSheet<TraitTransient>()!;

// The macro form, not ExtractText(): ExtractText() resolves every <if> as level 0 with no job, so
// Fire loses its Firestarter line. Colours are presentation only and go; <if(...)> stays, so every
// level/job variant of the tooltip survives. tools/CheckSpanish evaluates them.
static string Text(Lumina.Text.ReadOnly.ReadOnlySeString s) =>
    Regex.Replace(s.ToMacroString(), @"<(?:edge)?colortype\(\d+\)>", "").Replace("<br>", "\n").Trim();

// Disciples of War (30) and Magic (31): every combat class and job, nothing crafting or gathering.
var battle = classSheet
    .Where(c => c.RowId != 0 && c.ClassJobCategory.RowId is 30 or 31)
    .ToList();

// A class's actions belong to the job it becomes: Pugilist's Bootshine is a Monk action.
// Arcanist becomes two jobs (SMN and SCH), so it stays as itself, as does anything with no job.
var jobOf = battle.ToDictionary(
    c => c.RowId,
    c => battle.Where(j => j.ClassJobParent.RowId == c.RowId && j.RowId != c.RowId).ToList() is [var job]
        ? job
        : c);

string Abbr(uint classId) => jobOf[classId].Abbreviation.ExtractText();

// Actions with no owning class (Elixir Field, Eukrasian Dosis…) are claimed only by their job
// category. Matching by abbreviation flag is the one place the sheet says whose they are.
var categoryFlags = battle
    .Select(c => (c.RowId, Flag: typeof(ClassJobCategory).GetProperty(c.Abbreviation.ExtractText())))
    .Where(x => x.Flag is not null)
    .ToList();

string? OwnerByCategory(ClassJobCategory category)
{
    var owners = categoryFlags
        .Where(x => (bool)(x.Flag!.GetValue(category) ?? false))
        .Select(x => Abbr(x.RowId))
        .Distinct()
        .ToList();

    return owners.Count == 1 ? owners[0] : null;
}

var actions = new List<string>();

foreach (var a in actionSheet)
{
    if (a.IsPvP || a.ClassJobLevel == 0 || a.Name.ExtractText().Length == 0)
        continue;

    // No owning class covers role actions, but also pet and NPC rows: only a player action is a role action.
    var classId = a.ClassJob.RowId;
    string? job = classId == uint.MaxValue ? (a.IsPlayerAction ? "ROLE" : null)
        : jobOf.ContainsKey(classId) ? Abbr(classId)
        : null;

    if (job is null && !a.IsPlayerAction && a.ClassJobCategory.IsValid)
        job = OwnerByCategory(a.ClassJobCategory.Value);

    if (job is null)
        continue;

    var description = actionTransient.TryGetRow(a.RowId, out var t) ? Text(t.Description) : "";

    actions.Add(string.Create(CultureInfo.InvariantCulture,
        $"        new({a.RowId}, {Q(a.Name.ExtractText())}, {Q(job)}, "
        + $"{Q(a.ClassJobCategory.IsValid ? a.ClassJobCategory.Value.Name.ExtractText() : "")}, "
        + $"{Q(a.ActionCategory.IsValid ? a.ActionCategory.Value.Name.ExtractText() : "")}, "
        + $"{a.ClassJobLevel}, {a.Cast100ms * 100}, {a.Recast100ms * 100}, {a.MaxCharges}, "
        + $"{a.Range}, {a.EffectRange}, {a.Icon}, {Q(description)}),"));
}

var traits = new List<string>();

foreach (var tr in traitSheet)
{
    var name = tr.Name.ExtractText();

    if (string.IsNullOrWhiteSpace(name) || tr.Level == 0 || !jobOf.ContainsKey(tr.ClassJob.RowId))
        continue;

    var description = traitTransient.TryGetRow(tr.RowId, out var t) ? Text(t.Description) : "";

    traits.Add(string.Create(CultureInfo.InvariantCulture,
        $"        new({tr.RowId}, {Q(name)}, {Q(Abbr(tr.ClassJob.RowId))}, {tr.Level}, {tr.Icon}, {Q(description)}),"));
}

// Sprint, Teleport, Limit Break…: their own sheet, with ids that overlap the Action sheet's.
// Some link to a real action (Sprint → Action 3), and the in-game tooltip shows THAT action's
// text, which says more (Sprint's adds the Jog lines). Both texts are kept.
var general = data.GetExcelSheet<GeneralAction>()!
    .Where(g => g.Name.ExtractText().Length > 0 && g.Description.ExtractText().Length > 0)
    .Select(g =>
    {
        var linked = g.Action.RowId != 0 && actionTransient.TryGetRow(g.Action.RowId, out var t) ? Text(t.Description) : "";

        return string.Create(CultureInfo.InvariantCulture,
            $"        new({g.RowId}, {Q(g.Name.ExtractText())}, {g.Icon}, {Q(Text(g.Description))}, {g.Action.RowId}, {Q(linked)}),");
    })
    .ToList();

// Buffs and debuffs. The sheet has no owner worth trusting (Astral Fire is filed under "All
// Classes"), so every row with text goes out and tools/CheckSpanish picks a job's by name.
var statuses = data.GetExcelSheet<Status>()!
    .Where(s => s.Name.ExtractText().Length > 0 && s.Description.ExtractText().Length > 0)
    .Select(s => string.Create(CultureInfo.InvariantCulture,
        $"        new({s.RowId}, {Q(s.Name.ExtractText())}, {s.Icon}, {s.StatusCategory}, {Q(Text(s.Description))}),"))
    .ToList();

var jobs = battle
    .Where(c => jobOf[c.RowId].RowId == c.RowId) // jobs, plus ACN; other base classes are ParentAbbr
    .Select(c => string.Create(CultureInfo.InvariantCulture,
        $"        new({c.RowId}, {Q(c.Abbreviation.ExtractText())}, {Q(c.NameEnglish.ExtractText())}, "
        + $"{Q(c.ClassJobParent.RowId != c.RowId ? c.ClassJobParent.Value.Abbreviation.ExtractText() : "")}, {c.Role}),"))
    .ToList();

var f = new StringBuilder();
f.AppendLine("// <auto-generated />");
f.AppendLine("// Written by tools/ExtractGameData from the installed game's Excel sheets (English).");
f.AppendLine("// Do not edit by hand: re-run the tool after a patch.");
f.AppendLine($"// Extracted {DateTime.UtcNow:yyyy-MM-dd}.");
f.AppendLine();
f.AppendLine("namespace AstralES.Data;");
f.AppendLine();
f.AppendLine("/// <param name=\"ParentAbbr\">Base class it grows from (PGL for MNK), empty when none.</param>");
f.AppendLine("/// <param name=\"Role\">Game's role byte: 1 tank, 2 melee, 3 ranged, 4 healer.</param>");
f.AppendLine("public readonly record struct JobData(uint Id, string Abbr, string Name, string ParentAbbr, int Role);");
f.AppendLine();
f.AppendLine("/// <param name=\"Job\">Job abbreviation that owns it (class actions folded into their job), or ROLE.</param>");
f.AppendLine("/// <param name=\"UsableBy\">The game's ClassJobCategory text, e.g. \"PLD WAR DRK GNB\".</param>");
f.AppendLine("/// <param name=\"Category\">Spell, Weaponskill, Ability…</param>");
f.AppendLine("/// <param name=\"Range\">Yalms; -1 means melee range per the sheet.</param>");
f.AppendLine("/// <param name=\"Description\">Original tooltip text, colours stripped. Level/job-dependent parts stay as the game's");
f.AppendLine("/// <c>&lt;if([gnum72&gt;=58],then,else)&gt;</c> macros (gnum68 = class/job id, gnum72 = level); commas inside them are escaped as <c>\\,</c>.</param>");
f.AppendLine("public readonly record struct ActionData(uint Id, string Name, string Job, string UsableBy, string Category,");
f.AppendLine("    int Level, int CastMs, int RecastMs, int MaxCharges, int Range, int Radius, uint Icon, string Description);");
f.AppendLine();
f.AppendLine("public readonly record struct TraitData(uint Id, string Name, string Job, int Level, uint Icon, string Description);");
f.AppendLine();
f.AppendLine("/// <summary>A row of the GeneralAction sheet. Its ids overlap the Action sheet's, so it is kept apart.</summary>");
f.AppendLine("/// <param name=\"ActionId\">The Action row it triggers (Sprint → 3), 0 when none.</param>");
f.AppendLine("/// <param name=\"ActionDescription\">That action's own text, which is what the in-game tooltip shows; empty when none.</param>");
f.AppendLine("public readonly record struct GeneralActionData(uint Id, string Name, uint Icon, string Description, uint ActionId, string ActionDescription);");
f.AppendLine();
f.AppendLine("/// <param name=\"Category\">1 beneficial, 2 detrimental, 0 neither.</param>");
f.AppendLine("public readonly record struct StatusData(uint Id, string Name, uint Icon, int Category, string Description);");
f.AppendLine();
f.AppendLine("public static class GameData");
f.AppendLine("{");
f.AppendLine("    public static readonly JobData[] Jobs =");
f.AppendLine("    [");
jobs.ForEach(l => f.AppendLine(l));
f.AppendLine("    ];");
f.AppendLine();
f.AppendLine("    public static readonly ActionData[] Actions =");
f.AppendLine("    [");
actions.ForEach(l => f.AppendLine(l));
f.AppendLine("    ];");
f.AppendLine();
f.AppendLine("    public static readonly TraitData[] Traits =");
f.AppendLine("    [");
traits.ForEach(l => f.AppendLine(l));
f.AppendLine("    ];");
f.AppendLine();
f.AppendLine("    public static readonly GeneralActionData[] GeneralActions =");
f.AppendLine("    [");
general.ForEach(l => f.AppendLine(l));
f.AppendLine("    ];");
f.AppendLine();
f.AppendLine("    public static readonly StatusData[] Statuses =");
f.AppendLine("    [");
statuses.ForEach(l => f.AppendLine(l));
f.AppendLine("    ];");
f.AppendLine();
f.AppendLine("    public static readonly IReadOnlyDictionary<uint, ActionData> ActionById = Actions.ToDictionary(a => a.Id);");
f.AppendLine("}");

var full = Path.GetFullPath(output);
Directory.CreateDirectory(Path.GetDirectoryName(full)!);
File.WriteAllText(full, f.ToString(), new UTF8Encoding(false));

Console.WriteLine($"{jobs.Count} jobs, {actions.Count} actions, {traits.Count} traits, {general.Count} general actions, {statuses.Count} statuses → {full}");
return 0;

// C# string literal: escapes quotes, backslashes and every control character (newlines included).
static string Q(string s)
{
    var b = new StringBuilder("\"");

    foreach (var c in s)
    {
        b.Append(c switch
        {
            '"' => "\\\"",
            '\\' => "\\\\",
            '\n' => "\\n",
            _ when char.IsControl(c) => $"\\u{(int)c:x4}",
            _ => c.ToString(),
        });
    }

    return b.Append('"').ToString();
}
