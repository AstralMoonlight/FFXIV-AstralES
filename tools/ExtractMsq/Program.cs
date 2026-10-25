// Reads the installed game's quest text (English, with its macros) for the main scenario and
// "Chronicles of a New Era", and writes one TSV per quest, in journal order, plus the voiced
// cutscene sheets, an index and an inventory of every macro the text uses. Each quest and
// cutscene sheet is also written in Japanese, the original script, to msq/ja/ next to msq/en/:
// a reference for tone and register, never translated from directly.
//
//     dotnet run --project tools/ExtractMsq -- [sqpack path] [output folder]
//
// Re-run after every patch. The output is a dump of the game's text, so it is not committed.

using System.Text;
using System.Text.RegularExpressions;
using Lumina;
using Lumina.Data;
using Lumina.Excel;
using Lumina.Excel.Sheets;

const string DefaultSqpack = @"D:\SteamLibrary\steamapps\common\FINAL FANTASY XIV Online\game\sqpack";

var sqpack = args.Length > 0 ? args[0] : DefaultSqpack;
var output = Path.GetFullPath(args.Length > 1
    ? args[1]
    : Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "msq", "en"));

if (!Directory.Exists(sqpack))
{
    Console.Error.WriteLine($"no sqpack folder at: {sqpack}");
    return 1;
}

var data = new GameData(sqpack, new LuminaOptions { DefaultExcelLanguage = Language.English });
var quests = data.GetExcelSheet<Quest>()!;
var genres = data.GetExcelSheet<JournalGenre>()!;
var sheetNames = data.Excel.SheetNames.ToHashSet();

// Journal genres 1–15 are the main scenario (Seventh Umbral Era … Winter's Prelude), 16–33
// "Chronicles of a New Era". Genre 0 holds old versions the game no longer offers.
static bool Wanted(uint genre) => genre is >= 1 and <= 33;

var chosen = quests.Where(q => Wanted(q.JournalGenre.RowId)).ToList();

// "Coming to Gridania" (and its Limsa and Ul'dah twins) sits among each city's sidequests but is
// where the story starts: every Man* quest a chosen quest needs goes in, just before it.
var extra = chosen
    .SelectMany(q => q.PreviousQuest.Select(p => (Quest: p, Next: q)))
    .Where(x => x.Quest.RowId != 0 && x.Quest.IsValid && !Wanted(x.Quest.Value.JournalGenre.RowId)
        && x.Quest.Value.Id.ExtractText().StartsWith("Man"))
    .GroupBy(x => x.Quest.RowId)
    .Select(g => (Quest: g.First().Quest.Value, Next: g.MinBy(x => x.Next.SortKey).Next))
    .ToList();

// Every entry of the work list: a quest (or an opening, which has text but no Quest row),
// placed in a genre at a journal position.
var entries = chosen.Select(q => new Entry(q.JournalGenre.RowId, q.SortKey, 0, q.Id.ExtractText(), q.Name.ExtractText(), q.RowId))
    .Concat(extra.Select(x => new Entry(x.Next.JournalGenre.RowId, x.Next.SortKey, -1, x.Quest.Id.ExtractText(), x.Quest.Name.ExtractText(), x.Quest.RowId)))
    .ToList();

// The opening cutscene (the carriage ride, "Hear... Feel... Think...") is its own text sheet,
// Man<city>000, with no Quest row. It plays right before that city's "Coming to…".
foreach (var opening in sheetNames.Where(n => Regex.IsMatch(n, @"^quest/\d{3}/Man\w{3}000_\d{5}$")))
{
    var id = opening[(opening.LastIndexOf('/') + 1)..];
    var coming = entries.Single(e => e.Order == -1 && e.Id.StartsWith(id[..6]));
    entries.Add(coming with { Order = -2, Id = id, Name = $"{coming.Name} (opening)", QuestRow = 0 });
}

entries = entries.OrderBy(e => e.Genre).ThenBy(e => e.SortKey).ThenBy(e => e.Order).ThenBy(e => e.QuestRow).ToList();

var outputJa = Path.Combine(Path.GetDirectoryName(output)!, "ja");

foreach (var dir in new[] { output, outputJa })
    if (Directory.Exists(dir))
        Directory.Delete(dir, recursive: true);

var macros = new Dictionary<string, (int Count, string Example)>();
var index = new StringBuilder("order\tfolder\tfile\tquest\tname\tlines\n");
var totalLines = 0;
var missing = new List<string>();

foreach (var (e, i) in entries.Select((e, i) => (e, i + 1)))
{
    var genre = genres.GetRow(e.Genre).Name.ExtractText();
    var folder = $"{e.Genre:00}-{Slug(genre)}";
    var sheet = $"quest/{e.Id[^5..^2]}/{e.Id}";

    if (!sheetNames.Contains(sheet))
    {
        missing.Add($"{e.Id} {e.Name}");
        continue;
    }

    var file = $"{i:0000}-{e.Id}.tsv";
    var lines = WriteSheet(sheet, Path.Combine(output, folder, file));
    totalLines += lines;
    index.Append($"{i}\t{folder}\t{file}\t{e.QuestRow}\t{e.Name}\t{lines}\n");
}

// Voiced cutscenes (patch 2.2 onwards) live in their own sheets, one or more per patch, and
// name no quest: VoiceMan_03200 is patch 3.2. They are kept apart, in sheet order.
var cutscenes = sheetNames.Where(n => n.StartsWith("cut_scene/")).Order().ToList();
var cutsceneLines = 0;

foreach (var sheet in cutscenes)
{
    var file = $"{sheet[(sheet.LastIndexOf('/') + 1)..]}.tsv";
    var lines = WriteSheet(sheet, Path.Combine(output, "cutscenes", file));
    cutsceneLines += lines;
    index.Append($"\tcutscenes\t{file}\t0\t\t{lines}\n");
}

// The tutorial right after the opening cutscene: the welcome box ("Welcome to Gridania, a vibrant
// forest nation..."), the control scheme choice and the guards who turn you back to the guild.
foreach (var sheet in sheetNames.Where(n => n.StartsWith("opening/")).Order())
{
    var file = $"{sheet[(sheet.LastIndexOf('/') + 1)..]}.tsv";
    index.Append($"\topenings\t{file}\t0\t\t{WriteSheet(sheet, Path.Combine(output, "openings", file))}\n");
}

// Class and job quests (ClsLnc…, JobDrg…): one folder per journal genre, numbered in journal order.
// Jobs from Shadowbringers on use expansion ids (LucKbb…, AktKbb…, KinGbb…): their journal
// category (93/94, "Disciple of War/Magic Job Quests") brings them in.
var jobQuests = quests.Where(q => q.JournalGenre.RowId != 0 && q.Id.ExtractText() is var id
        && (id.StartsWith("Cls") || id.StartsWith("Job") || q.JournalGenre.Value.JournalCategory.RowId is 93 or 94))
    .GroupBy(q => q.JournalGenre.RowId).OrderBy(g => g.Key);
var jobLines = 0;

foreach (var group in jobQuests)
{
    var folder = $"jobs/{group.Key:000}-{Slug(genres.GetRow(group.Key).Name.ExtractText())}";

    foreach (var (q, i) in group.OrderBy(q => q.SortKey).ThenBy(q => q.RowId).Select((q, i) => (q, i + 1)))
    {
        var id = q.Id.ExtractText();
        var sheet = $"quest/{id[^5..^2]}/{id}";

        if (!sheetNames.Contains(sheet))
            continue;

        var file = $"{i:00}-{id}.tsv";
        var lines = WriteSheet(sheet, Path.Combine(output, folder, file));
        jobLines += lines;
        index.Append($"\t{folder}\t{file}\t{q.RowId}\t{q.Name.ExtractText()}\t{lines}\n");
    }
}

// Joining a combat guild ("So You Want to Be a Thaumaturge": the receptionist's welcome and the
// yes/no) is a quest the journal files under no genre. It goes first in its class's folder, as 00.
foreach (var q in quests.Where(q => q.JournalGenre.RowId == 0 && q.ClassJobUnlock.RowId != 0 && q.Id.ExtractText().StartsWith("Cls")))
{
    var id = q.Id.ExtractText();
    var mate = quests.FirstOrDefault(j => j.JournalGenre.RowId != 0 && j.Id.ExtractText().StartsWith(id[..6]));
    var sheet = $"quest/{id[^5..^2]}/{id}";

    if (mate.RowId == 0 || !sheetNames.Contains(sheet))
    {
        missing.Add($"guild {id}");
        continue;
    }

    var folder = $"jobs/{mate.JournalGenre.RowId:000}-{Slug(genres.GetRow(mate.JournalGenre.RowId).Name.ExtractText())}";
    var lines = WriteSheet(sheet, Path.Combine(output, folder, $"00-{id}.tsv"));
    jobLines += lines;
    index.Append($"\t{folder}\t00-{id}.tsv\t{q.RowId}\t{q.Name.ExtractText()}\t{lines}\n");
}

Console.WriteLine($"class and job quests: {jobLines} lines → {Path.Combine(output, "jobs")}");

// Sidequests that unlock a game feature, picked by name: the aesthetician, glamours and dyes.
string[] featureNames = ["Beauty Is Only Scalp Deep", "If I Had a Glamour", "Color Your World"];

foreach (var (name, i) in featureNames.Select((n, i) => (n, i + 1)))
{
    var q = quests.FirstOrDefault(q => q.Name.ExtractText() == name && q.JournalGenre.RowId != 0);
    var id = q.RowId == 0 ? "" : q.Id.ExtractText();

    if (id.Length == 0 || !sheetNames.Contains($"quest/{id[^5..^2]}/{id}"))
    {
        missing.Add($"feature {name}");
        continue;
    }

    var file = $"{i:00}-{id}.tsv";
    index.Append($"\tfeatures\t{file}\t{q.RowId}\t{name}\t{WriteSheet($"quest/{id[^5..^2]}/{id}", Path.Combine(output, "features", file))}\n");
}

// The events running now, numbered in this order: All Saints' Wake 2026 (its two quests, then what
// the event NPCs say outside them: the guide, the witch, the warp into the horror room) and the
// Fall Guys event (the Blunderville quest and the guide at its gate).
string[] eventIds = ["FesHlx201_", "FesHlx202_", "FesHlx2026", "SubGsc901_", "CtsEtcFgsEntrance_"];
var eventSheets = sheetNames.Where(n => (n.StartsWith("quest/") || n.StartsWith("custom/"))
        && eventIds.Any(id => n[(n.LastIndexOf('/') + 1)..].StartsWith(id)))
    .OrderBy(n => Array.FindIndex(eventIds, id => n[(n.LastIndexOf('/') + 1)..].StartsWith(id))).ThenBy(n => n).ToList();

if (eventSheets.Count < eventIds.Length)
    missing.Add($"event sheets: found only {string.Join(", ", eventSheets)}");

foreach (var (sheet, i) in eventSheets.Select((s, i) => (s, i + 1)))
{
    var file = $"{i:00}-{sheet[(sheet.LastIndexOf('/') + 1)..]}.tsv";
    index.Append($"\tevents\t{file}\t0\t\t{WriteSheet(sheet, Path.Combine(output, "events", file))}\n");
}

// Travel: the aetheryte menu, the "You have attuned yourself to all the Aethernet shards..."
// messages and the chocobo porters. One sheet per name, no quest id: transport/Aetheryte.
foreach (var sheet in sheetNames.Where(n => n.StartsWith("transport/")).Order())
{
    var file = $"{sheet[(sheet.LastIndexOf('/') + 1)..]}.tsv";
    index.Append($"\ttransport\t{file}\t0\t\t{WriteSheet(sheet, Path.Combine(output, "transport", file))}\n");
}

// Interface text (Addon: window titles, buttons, labels, confirmations; AddonTransient: controller
// hints). Each distinct text once, under its first row, one file per 500 row ids:
// addon/NNN-Addon.tsv holds rows NNN*500 to NNN*500+499, so a patch that adds rows leaves the other
// files as they were. The plugin looks a row's English up in the game and gives every row with that
// text the Spanish.
foreach (var name in new[] { "Addon", "AddonTransient" })
{
    var rows = data.Excel.GetSheet<RawRow>(Language.English, name);
    var seen = new HashSet<string>();
    var chunk = new List<string>();
    var block = -1;

    void Flush()
    {
        if (chunk.Count == 0)
            return;

        var file = $"{block:000}-{name}.tsv";
        Directory.CreateDirectory(Path.Combine(output, "addon"));
        File.WriteAllText(Path.Combine(output, "addon", file), "key\tspeaker\ttext\n" + string.Concat(chunk), new UTF8Encoding(false));
        index.Append($"\taddon\t{file}\t0\t\t{chunk.Count}\n");
        chunk.Clear();
    }

    foreach (var row in rows)
    {
        for (var c = 0; c < rows.Columns.Count; c++)
        {
            if (rows.Columns[c].Type != Lumina.Data.Structs.Excel.ExcelColumnDataType.String)
                continue;

            var column = row.ReadStringColumn(c);
            var text = column.ToMacroString().Replace("\r", "").Replace("\n", "<br>");

            // Nothing to translate without Latin letters outside the macros (a lone <icon2(12)>);
            // rows the global release never wrote stay Japanese (kana or kanji; the English text
            // uses the middle dot ・ for bullets).
            if (!column.ExtractText().Any(char.IsAsciiLetter) || text.Any(ch => ch is >= 'ぁ' and <= 'ヺ' or >= '一' and <= '鿿')
                || !seen.Add(text))
                continue;

            if (text.Contains('\t'))
                throw new InvalidDataException($"{name} {row.RowId}: tab in the text, the TSV would break");

            if (row.RowId / 500 != block)
            {
                Flush();
                block = (int)(row.RowId / 500);
            }

            chunk.Add($"TEXT_{name.ToUpperInvariant()}_{row.RowId}{(c == 0 ? "" : $"_{c}")}\t\t{text}\n");
        }
    }

    Flush();
    Console.WriteLine($"{name}: {seen.Count} distinct texts → {Path.Combine(output, "addon")}");
}

// What bosses say mid-fight in dungeons, trials and raids ("Drag them unto the depths, O chains!"),
// plus the duty's objective. Each duty names its block of InstanceContentTextData rows; the normal
// and savage versions share one block (savage's may run longer), so a block is written once, under
// the duty that starts it with the lowest row: duties/<InstanceContent row>-Duty<row>.tsv.
var dutyText = data.Excel.GetSheet<RawRow>(Language.English, "InstanceContentTextData");
var dutyLines = 0;

foreach (var block in data.GetExcelSheet<InstanceContent>()!
    .Where(ic => ic.InstanceContentTextDataObjectiveStart.RowId != 0 && ic.ContentFinderCondition.IsValid)
    .GroupBy(ic => ic.InstanceContentTextDataObjectiveStart.RowId))
{
    var duty = block.MinBy(ic => ic.RowId);
    var id = $"Duty{duty.RowId}";
    var end = block.Max(ic => ic.InstanceContentTextDataObjectiveEnd.RowId);
    var b = new StringBuilder("key\tspeaker\ttext\n");
    var count = 0;

    for (var row = block.Key; row <= end; row++)
    {
        var text = dutyText.HasRow(row) ? dutyText.GetRow(row).ReadStringColumn(0).ToMacroString() : "";

        // Rows never written for the global release keep their Japanese text.
        if (text.Length == 0 || text.Any(c => c is >= '　' and <= '鿿'))
            continue;

        if (text.IndexOfAny(['\t', '\n', '\r']) >= 0)
            throw new InvalidDataException($"InstanceContentTextData {row}: tab or line break in the text, the TSV would break");

        b.Append($"TEXT_{id.ToUpperInvariant()}_{row}\t\t{text}\n");
        count++;
    }

    if (count == 0)
        continue;

    var file = $"{duty.RowId}-{id}.tsv";
    Directory.CreateDirectory(Path.Combine(output, "duties"));
    File.WriteAllText(Path.Combine(output, "duties", file), b.ToString(), new UTF8Encoding(false));
    dutyLines += count;
    index.Append($"\tduties\t{file}\t0\t{duty.ContentFinderCondition.Value.Name.ExtractText()}\t{count}\n");
}

Console.WriteLine($"duties: {dutyLines} lines → {Path.Combine(output, "duties")}");

File.WriteAllText(Path.Combine(output, "index.tsv"), index.ToString(), new UTF8Encoding(false));
File.WriteAllText(Path.Combine(output, "macros.tsv"),
    "macro\tcount\texample\n" + string.Concat(macros.OrderByDescending(m => m.Value.Count)
        .Select(m => $"{m.Key}\t{m.Value.Count}\t{m.Value.Example}\n")),
    new UTF8Encoding(false));

var expected = chosen.Count + extra.Count;
var written = entries.Count - missing.Count;
Console.WriteLine($"{written} quests and openings ({chosen.Count} from genres 1–33, {extra.Count} city starts, "
    + $"{entries.Count - expected} openings), {totalLines} lines; {cutscenes.Count} cutscene sheets, {cutsceneLines} lines → {output}");
Console.WriteLine($"{macros.Count} macro types: {string.Join(", ", macros.OrderByDescending(m => m.Value.Count).Select(m => $"{m.Key} {m.Value.Count}"))}");

if (missing.Count > 0)
{
    Console.Error.WriteLine($"{missing.Count} quests have no text sheet: {string.Join("; ", missing)}");
    return 1;
}

return 0;

// One row per non-empty line: key, who says it, and the text in macro form. Rows stay in sheet
// order, which is the order they play in.
int WriteSheet(string sheet, string path)
{
    var rows = data.Excel.GetSheet<RawRow>(Language.English, sheet);
    var prefix = $"TEXT_{sheet[(sheet.LastIndexOf('/') + 1)..].ToUpperInvariant()}_";
    var b = new StringBuilder("key\tspeaker\ttext\n");
    var count = 0;

    foreach (var row in rows)
    {
        var key = row.ReadStringColumn(0).ExtractText();
        var text = row.ReadStringColumn(1).ToMacroString();

        if (key.Length == 0 || text.Length == 0)
            continue;

        if (text.IndexOfAny(['\t', '\n', '\r']) >= 0 || key.IndexOfAny(['\t', '\n', '\r']) >= 0)
            throw new InvalidDataException($"{sheet} {key}: tab or line break in the text, the TSV would break");

        // \<sigh> and the like are plain text (escaped '<'), not macros. <--> is a compound word's hyphen.
        foreach (Match m in Regex.Matches(text, @"(?<!\\)<(/?[a-zA-Z][a-zA-Z0-9]*|--)[(>]"))
        {
            var name = m.Groups[1].Value;
            macros[name] = macros.TryGetValue(name, out var seen) ? (seen.Count + 1, seen.Example) : (1, key);
        }

        b.Append($"{key}\t{Speaker(key, prefix)}\t{text}\n");
        count++;
    }

    if (count > 0)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, b.ToString(), new UTF8Encoding(false));
        WriteJapanese(sheet, Path.Combine(outputJa, Path.GetRelativePath(output, path)));
    }

    return count;
}

// The same sheet in Japanese, same keys: key, text.
void WriteJapanese(string sheet, string path)
{
    var b = new StringBuilder("key\ttext\n");

    foreach (var row in data.Excel.GetSheet<RawRow>(Language.Japanese, sheet))
    {
        var key = row.ReadStringColumn(0).ExtractText();
        var text = row.ReadStringColumn(1).ToMacroString().Replace("\t", " ").Replace("\r", "").Replace("\n", "<br>");

        if (key.Length > 0 && text.Length > 0)
            b.Append($"{key}\t{text}\n");
    }

    Directory.CreateDirectory(Path.GetDirectoryName(path)!);
    File.WriteAllText(path, b.ToString(), new UTF8Encoding(false));
}

// TEXT_MANFST000_00083_BREMONDT_000_1 → BREMONDT; _100040_NARRATION → NARRATION; _SEQ_00 → SEQ
// (journal), _TODO_00 → TODO (objective), _Q1_000_1 / _A1_000_1 → Q1 / A1 (question and answers).
static string Speaker(string key, string prefix)
{
    var rest = key.StartsWith(prefix) ? key[prefix.Length..] : key;
    return rest.Split('_').FirstOrDefault(t => t.Length > 0 && !t.All(char.IsDigit)) ?? "";
}

static string Slug(string s) =>
    Regex.Replace(s.ToLowerInvariant().Replace("æ", "ae").Replace("'", ""), "[^a-z0-9]+", "-").Trim('-');

/// <param name="Order">-2 opening, -1 city start, 0 the quest itself: breaks ties at the same journal position.</param>
/// <param name="QuestRow">Row in the Quest sheet, 0 for an opening.</param>
record Entry(uint Genre, ushort SortKey, int Order, string Id, string Name, uint QuestRow);
