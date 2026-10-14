// Reads the installed game's quest text (English, with its macros) for the main scenario and
// "Chronicles of a New Era", and writes one TSV per quest, in journal order, plus the voiced
// cutscene sheets, an index and an inventory of every macro the text uses.
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

if (Directory.Exists(output))
    Directory.Delete(output, recursive: true);

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
    }

    return count;
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
