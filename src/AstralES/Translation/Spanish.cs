using System.Text.RegularExpressions;

namespace AstralES.Translation;

/// <summary>
/// Tooltip lines in Latin American Spanish, keyed by the English line with its numbers replaced by
/// {0}, {1}… in order. A patch that changes a potency or a duration does not break the translation,
/// the Spanish can reorder the numbers, and a line shared by several abilities is translated once.
/// <para>
/// Proper names the game shows elsewhere (actions, statuses, gauges) stay in English, so they still
/// match the hotbar, the status bar and the guides. A line with no entry stays in English.
/// </para>
/// </summary>
public static partial class Spanish
{
    private static readonly List<string> duplicates = [];

    /// <summary>Keys added more than once across the Lines.*.cs files.</summary>
    public static IReadOnlyList<string> Duplicates => duplicates;

    private static readonly Regex Number = new(@"\d+(?:[.,]\d+)*", RegexOptions.Compiled);

    public static string Template(string line)
    {
        var i = 0;
        return Number.Replace(line.Trim(), _ => $"{{{i++}}}");
    }

    /// <summary>Spanish for one line, or null when there is none.</summary>
    public static string? Line(string line)
    {
        if (!Lines.TryGetValue(Template(line), out var spanish))
            return null;

        var numbers = Number.Matches(line).Select(m => (object)m.Value).ToArray();
        return string.Format(spanish, numbers);
    }

    /// <summary>Whole tooltip text, line by line; untranslated lines stay in English.</summary>
    public static string Text(string english) =>
        string.Join('\n', english.Split('\n').Select(l => l.Trim().Length == 0 ? l : Line(l) ?? l));

    // ------------------------------------------------------------------ Colours

    private static readonly Regex MacroTag = new(@"(?<!\\)(<[^<>]*>)", RegexOptions.Compiled);
    private static readonly Regex ColourTag = new(@"^<(?:edge)?colortype\((\d+)\)>$", RegexOptions.Compiled);

    private readonly record struct Span(string Open, string Text, string Close, bool AtStart);

    /// <summary>
    /// One line in the game's macro form (<c>&lt;colortype(504)&gt;Duration: &lt;colortype(0)&gt;24s</c>),
    /// translated with its colours kept; null when the line has no translation.
    /// <para>
    /// The colour goes back on the same text in the Spanish: proper names are never translated
    /// (rule 1), so "Astral Fire" is found as is. A coloured label at the start of the line
    /// ("Duration:", "Additional Effect:") is translated, so it becomes everything up to the
    /// first ':' of the Spanish. Coloured text that cannot be found loses its colour, nothing else.
    /// Any other tag is left out of the Spanish and added to <paramref name="dropped"/>, so the
    /// caller can report it: a translated line without some tag beats an English one.
    /// </para>
    /// </summary>
    public static string? MacroLine(string macro, ICollection<string>? dropped = null)
    {
        var parts = MacroTag.Split(macro); // text at even indices, tags at odd
        var plain = new System.Text.StringBuilder();
        var spans = new List<Span>();
        string open = "", text = "", close = "";
        var start = 0;

        void Finish()
        {
            if (open.Length > 0 && text.Length > 0)
                spans.Add(new Span(open, text, close, start == 0));

            open = text = close = "";
        }

        for (var i = 0; i < parts.Length; i++)
        {
            var part = parts[i];

            if (part.Length == 0)
                continue;

            if (i % 2 == 1)
            {
                var colour = ColourTag.Match(part);

                if (!colour.Success)
                {
                    dropped?.Add(part);
                    continue;
                }

                if (colour.Groups[1].Value != "0")
                {
                    if (close.Length > 0)
                        Finish();

                    if (open.Length == 0)
                        start = plain.Length;

                    open += part;
                }
                else
                {
                    close += part;
                }

                continue;
            }

            var unescaped = Regex.Replace(part, @"\\(.)", "$1");

            if (close.Length > 0)
                Finish();

            if (open.Length > 0)
                text += unescaped;

            plain.Append(unescaped);
        }

        Finish();

        var spanish = Line(plain.ToString());

        if (spanish is null)
            return null;

        var marks = new List<(int From, int To, string Open, string Close)>();
        var cursor = 0;

        bool Free(int from, int to) => marks.All(m => to <= m.From || from >= m.To);

        foreach (var span in spans)
        {
            int from = -1, to = -1;
            var label = span.Text.Trim();

            if (span.AtStart && label.EndsWith(':'))
            {
                var colon = spanish.IndexOf(':');

                if (colon >= 0)
                    (from, to) = (0, colon + 1 + (span.Text.EndsWith(' ') && colon + 1 < spanish.Length && spanish[colon + 1] == ' ' ? 1 : 0));
            }
            else
            {
                var at = spanish.IndexOf(label, cursor, StringComparison.Ordinal);

                if (at < 0)
                    at = spanish.IndexOf(label, StringComparison.Ordinal);

                if (at >= 0)
                    (from, to) = (at, at + label.Length);
            }

            if (from < 0 || !Free(from, to))
                continue;

            marks.Add((from, to, span.Open, span.Close));
            cursor = to;
        }

        var result = new System.Text.StringBuilder();
        var position = 0;

        foreach (var (from, to, o, c) in marks.OrderBy(m => m.From))
        {
            result.Append(Escape(spanish[position..from])).Append(o).Append(Escape(spanish[from..to])).Append(c);
            position = to;
        }

        return result.Append(Escape(spanish[position..])).ToString();
    }

    /// <summary>A whole tooltip text in macro form, line by line; untranslated lines stay as they were.</summary>
    /// <remarks>
    /// The game's own tooltip text separates lines with a real '\n', not <c>&lt;br&gt;</c> as the
    /// sheets do; both are split on, and each separator is put back exactly as it was.
    /// </remarks>
    public static string Macro(string macro, ICollection<string>? dropped = null)
    {
        var parts = LineBreak.Split(macro); // lines at even indices, separators at odd

        for (var i = 0; i < parts.Length; i += 2)
            parts[i] = MacroLine(parts[i], dropped) ?? parts[i];

        return string.Concat(parts);
    }

    private static readonly Regex LineBreak = new(@"(<br>|\r\n|\n|\r)", RegexOptions.Compiled);

    private static string Escape(string text) => text.Replace(@"\", @"\\").Replace("<", @"\<");

    /// <summary>
    /// English template → Spanish, built from one file per section (<c>Lines.*.cs</c>). A key added
    /// twice keeps the first translation and is listed in <see cref="Duplicates"/>, which
    /// tools/CheckSpanish reports as an error.
    /// </summary>
    public static readonly IReadOnlyDictionary<string, string> Lines = Build();

    private static Dictionary<string, string> Build()
    {
        var lines = new Dictionary<string, string>();

        void Add(string english, string spanish)
        {
            if (!lines.TryAdd(english, spanish))
                duplicates.Add(english);
        }

        Generic(Add);
        Role(Add);
        General(Add);
        Blm(Add);
        Whm(Add);
        Sge(Add);
        Brd(Add);
        Dnc(Add);
        Mnk(Add);
        Vpr(Add);
        Drk(Add);
        Drg(Add);
        War(Add);
        Pld(Add);
        Gnb(Add);
        Acn(Add);
        Sch(Add);
        Ast(Add);
        Nin(Add);
        Sam(Add);
        Rpr(Add);
        Mch(Add);
        Smn(Add);
        Rdm(Add);
        Pct(Add);
        Bst(Add);
        Blu(Add);

        return lines;
    }
}
