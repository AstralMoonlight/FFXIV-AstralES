// Translation progress and sanity check. No game needed.
//
//     dotnet run --project tools/CheckSpanish -- BLM ROLE     (no args: every job)
//     dotnet run --project tools/CheckSpanish -- BLM --ver    (also prints each tooltip in Spanish, as the job sees it at level 100)
//
// For each job: how many abilities are fully translated in every level/job variant of their
// tooltip, and which English lines are still missing. Exits 1 if a Spanish line uses different
// placeholders than its English key, or a description has a macro this cannot evaluate.

using System.Text;
using System.Text.RegularExpressions;
using AstralES.Data;
using AstralES.Translation;

var show = args.Contains("--ver");
args = args.Where(a => a != "--ver").ToArray();

var jobs = args.Length > 0
    ? args.Select(a => a.ToUpperInvariant()).ToList()
    : GameData.Jobs.Select(j => j.Abbr).Append("ROLE").Append("GENERAL").ToList();

var errors = 0;

// Colours: real lines from the game's macro text, and where each colour must land in the Spanish.
const string Label = "<colortype(504)><edgecolortype(505)>", Name = "<colortype(506)><edgecolortype(507)>",
    Action = "<colortype(500)><edgecolortype(501)>", End = "<edgecolortype(0)><colortype(0)>";

ExpectColours($"{Label}Duration: {End}24s", $"{Label}Duración: {End}24 s");
ExpectColours($"{Label}Additional Effect:{End} Grants {Name}Astral Fire{End} or removes {Name}Umbral Ice{End}",
    $"{Label}Efecto adicional:{End} Otorga {Name}Astral Fire{End} o elimina {Name}Umbral Ice{End}");
ExpectColours($"{Label}Firestarter Effect: {End}Next {Action}Fire III{End} will cost no MP and have no cast time",
    $"{Label}Efecto de Firestarter: {End}El siguiente {Action}Fire III{End} no consume MP ni tiene tiempo de lanzamiento");
ExpectColours($"{Label}Umbral Heart Bonus: {End}Nullifies {Name}Astral Fire{End}'s MP cost increase for {Action}Fire{End} spells and reduces MP cost for {Action}Flare{End} by one-third",
    $"{Label}Bonificación de Umbral Heart: {End}Anula el aumento de costo de MP de {Name}Astral Fire{End} en los hechizos de fuego y reduce en un tercio el costo de MP de {Action}Flare{End}");
// "Fire spells" is translated ("hechizos de fuego"), so that "Fire" has nowhere to go and loses its
// colour; it must not land on the "Fire" inside "Astral Fire" either.
ExpectColours("Some line nobody translated", null);

// The whole Blizzard IV tooltip as the game hands it over at runtime (from /xllog): real '\n'
// between lines, not <br>. The first version split on <br> only and left everything in English.
var blizzardIv = $"Deals ice damage with a potency of 300.\n{Label}Additional Effect: {End}Grants 3 {Name}Umbral Hearts{End}\n"
    + $"Can only be executed while under the effect of {Name}Umbral Ice{End}.";
var blizzardIvEs = $"Inflige daño de hielo con una potencia de 300.\n{Label}Efecto adicional: {End}Otorga 3 {Name}Umbral Hearts{End}\n"
    + $"Solo se puede usar bajo el efecto de {Name}Umbral Ice{End}.";

if (Spanish.Macro(blizzardIv) != blizzardIvEs)
{
    Console.WriteLine($"ERROR texto completo:\n  esperado: {blizzardIvEs}\n  obtenido: {Spanish.Macro(blizzardIv)}");
    errors++;
}

void ExpectColours(string english, string? expected)
{
    var actual = Spanish.MacroLine(english);

    if (actual == expected)
        return;

    Console.WriteLine($"ERROR colores:\n  en:       {english}\n  esperado: {expected}\n  obtenido: {actual}");
    errors++;
}

foreach (var job in jobs)
{
    // Rows with no text (pet and helper actions) have nothing to translate and are not counted.
    // GENERAL is the GeneralAction sheet (Sprint, Teleport…), not a job of the Action sheet.
    var actions = job == "GENERAL"
        // Both texts: the sheet's own, and the linked action's, which is what the tooltip shows.
        ? GameData.GeneralActions.Select(g => (g.Id, g.Name, Level: 0, Description: (g.Description + "\n" + g.ActionDescription).Trim()))
        : GameData.Actions.Where(a => a.Job == job).Select(a => (a.Id, a.Name, a.Level, a.Description));

    // Traits are shown in the same ActionDetail tooltip, so they go through the same table.
    var traits = GameData.Traits.Where(t => t.Job == job).Select(t => (t.Id, t.Name, t.Level, t.Description));

    Report(job, "habilidades", actions);
    Report(job, "rasgos", traits);
    Report(job, "estados", StatusesOf(actions.Concat(traits).ToList()));
}

// A job's buffs and debuffs: the Status sheet names no owner, so a status is the job's when one of
// its abilities shares the name (Triplecast, Thunder…) or its text names it as a whole word
// ("Grants Firestarter", "Afflicts target with Heavy"). Rows repeated with the same text (PvP and
// duty copies) count once.
IEnumerable<(uint Id, string Name, int Level, string Description)> StatusesOf(
    List<(uint Id, string Name, int Level, string Description)> rows)
{
    var names = rows.Select(r => r.Name).ToHashSet();
    var text = string.Join("\n", rows.Select(r => r.Description));

    return GameData.Statuses
        .Where(s => names.Contains(s.Name) || MentionsWord(text, s.Name))
        .DistinctBy(s => (s.Name, s.Description))
        .Select(s => (s.Id, s.Name, Level: 0, s.Description));
}

static bool MentionsWord(string text, string word)
{
    for (var at = text.IndexOf(word, StringComparison.Ordinal); at >= 0; at = text.IndexOf(word, at + 1, StringComparison.Ordinal))
    {
        var end = at + word.Length;

        if ((at == 0 || !char.IsLetter(text[at - 1])) && (end == text.Length || !char.IsLetter(text[end])))
            return true;
    }

    return false;
}

void Report(string job, string kind, IEnumerable<(uint Id, string Name, int Level, string Description)> rows)
{
    var items = rows.Where(r => r.Description.Length > 0).ToList();

    if (items.Count == 0)
        return;

    var linesOf = items.ToDictionary(a => a.Id, a => Lines(a.Description).ToList());
    var all = linesOf.Values.SelectMany(l => l).Distinct().ToList();
    var missing = all.Where(l => !Spanish.Lines.ContainsKey(l)).ToList();
    var done = items.Count(a => linesOf[a.Id].All(Spanish.Lines.ContainsKey));

    Console.WriteLine($"{job} {kind}: {done}/{items.Count}, {all.Count - missing.Count}/{all.Count} líneas");

    foreach (var line in missing)
        Console.WriteLine($"  falta: {line}");

    if (!show)
        return;

    var jobId = (int)GameData.Jobs.FirstOrDefault(j => j.Abbr == job).Id;

    foreach (var a in items.OrderBy(a => a.Level))
    {
        var text = Eval(a.Description, new Dictionary<int, int> { [68] = jobId, [72] = 100 });
        Console.WriteLine($"\n[Nv {a.Level}] {a.Name}\n{Spanish.Text(text)}");
    }
}

foreach (var (english, spanish) in Spanish.Lines)
{
    var expected = Regex.Matches(english, @"\{\d+\}").Count;
    var used = Regex.Matches(spanish, @"\{(\d+)\}").Select(m => int.Parse(m.Groups[1].Value)).ToHashSet();

    // A key with a bare digit left in it was typed by hand and can never match a real line.
    var bareDigit = Regex.IsMatch(Regex.Replace(english, @"\{\d+\}", ""), @"\d");

    if (!used.SetEquals(Enumerable.Range(0, expected)) || bareDigit)
    {
        Console.WriteLine($"ERROR placeholders: \"{english}\" → \"{spanish}\"");
        errors++;
    }
}

foreach (var duplicate in Spanish.Duplicates)
{
    Console.WriteLine($"ERROR clave repetida en Lines.*.cs: \"{duplicate}\"");
    errors++;
}

return errors > 0 ? 1 : 0;

// Every distinct template line any level/job variant of this tooltip can show.
IEnumerable<string> Lines(string description)
{
    try
    {
        return Variants(description)
            .SelectMany(t => t.Split('\n'))
            .Where(l => l.Trim().Length > 0)
            .Select(Spanish.Template)
            .Distinct();
    }
    catch (FormatException e)
    {
        Console.WriteLine($"ERROR macro: {e.Message}");
        errors++;
        return [];
    }
}

// Tries each constant a condition compares against (and its neighbours) for every gnum the text
// reads — gnum68 class/job, gnum72 level — so every branch is taken at least once.
static IEnumerable<string> Variants(string macro)
{
    var candidates = Regex.Matches(macro, @"\[gnum(\d+)(?:==|!=|>=|<=|>|<)(\d+)\]")
        .GroupBy(m => int.Parse(m.Groups[1].Value))
        .Select(g => (Gnum: g.Key, Values: g.SelectMany(m => { var v = int.Parse(m.Groups[2].Value); return new[] { v - 1, v, v + 1 }; })
            .Append(0).Distinct().ToArray()));

    IEnumerable<Dictionary<int, int>> combos = [new()];

    foreach (var (gnum, values) in candidates)
        combos = combos.SelectMany(c => values.Select(v => new Dictionary<int, int>(c) { [gnum] = v })).ToList();

    return combos.Select(c => Eval(macro, c)).Distinct();
}

// Resolves <if([gnumN op V],then,else)>, nested, with \-escapes. Other tags are left as they are.
static string Eval(string s, IReadOnlyDictionary<int, int> gnum)
{
    var b = new StringBuilder();

    for (var i = 0; i < s.Length; i++)
    {
        if (s[i] == '\\' && i + 1 < s.Length)
        {
            b.Append(s[++i]);
            continue;
        }

        if (!s.AsSpan(i).StartsWith("<if("))
        {
            b.Append(s[i]);
            continue;
        }

        var args = new List<string>();
        var start = i + 4;
        var depth = 1;
        var j = start;

        for (; depth > 0; j++)
        {
            if (j >= s.Length)
                throw new FormatException($"unclosed <if> in: {s}");

            switch (s[j])
            {
                case '\\': j++; break;
                case '(': depth++; break;
                case ')': depth--; break;
                case ',' when depth == 1: args.Add(s[start..j]); start = j + 1; break;
            }
        }

        args.Add(s[start..(j - 1)]);

        if (j >= s.Length || s[j] != '>')
            throw new FormatException($"<if> not closed by '>' in: {s}");

        var branch = Holds(args[0], gnum) ? args.ElementAtOrDefault(1) : args.ElementAtOrDefault(2);
        b.Append(Eval(branch ?? "", gnum));
        i = j;
    }

    return b.ToString();
}

static bool Holds(string condition, IReadOnlyDictionary<int, int> gnum)
{
    var m = Regex.Match(condition, @"^\[gnum(\d+)(==|!=|>=|<=|>|<)(\d+)\]$");

    if (!m.Success)
        throw new FormatException($"unknown condition: {condition}");

    var left = gnum.GetValueOrDefault(int.Parse(m.Groups[1].Value));
    var right = int.Parse(m.Groups[3].Value);

    return m.Groups[2].Value switch
    {
        "==" => left == right,
        "!=" => left != right,
        ">=" => left >= right,
        "<=" => left <= right,
        ">" => left > right,
        _ => left < right,
    };
}
