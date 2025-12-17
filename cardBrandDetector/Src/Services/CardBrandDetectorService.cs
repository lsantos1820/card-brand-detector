using System.Text.RegularExpressions;
using CardBrandDetector.Src.Models;

namespace CardBrandDetector.Src.Services;

public sealed class CardBrandDetectorService
{
    private static readonly (string Brand, Regex Pattern)[] Patterns =
    {
        ("Visa", new Regex(@"^4(\d{12}|\d{15}|\d{18})$", RegexOptions.Compiled)),
        ("MasterCard", new Regex(@"^(5[1-5]\d{14}|2(2[2-9]\d{12}|[3-6]\d{13}|7(0\d{12}|1\d{12}|20\d{12})))$", RegexOptions.Compiled)),
        ("Amex", new Regex(@"^3[47]\d{13}$", RegexOptions.Compiled)),
        ("Discover", new Regex(@"^(6011\d{12}|65\d{14}|64[4-9]\d{13})\d{0,3}$", RegexOptions.Compiled)),
        ("Diners", new Regex(@"^3(0[0-5]\d{11}|[68]\d{12})$", RegexOptions.Compiled)),
        ("JCB", new Regex(@"^35(2[8-9]\d{12}|[3-8]\d{13})$", RegexOptions.Compiled)),
        ("Hipercard", new Regex(@"^(38\d{17}|60\d{14})$", RegexOptions.Compiled)),
    };

    public CardBrandResult Detect(string input)
    {
        var digitsOnly = Normalize(input);

        if (digitsOnly.Length < 12)
            return new CardBrandResult("Unknown");

        foreach (var (brand, pattern) in Patterns)
        {
            if (pattern.IsMatch(digitsOnly))
                return new CardBrandResult(brand);
        }

        return new CardBrandResult("Unknown");
    }

    public static string Normalize(string input)
    {
        return new string(input.Where(char.IsDigit).ToArray());
    }
}
