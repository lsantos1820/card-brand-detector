namespace CardBrandDetector.Src.Models;

public sealed class CardBrandResult
{
    public string Brand { get; }
    public bool IsRecognized => Brand != "Unknown";

    public CardBrandResult(string brand)
    {
        Brand = brand;
    }

    public override string ToString() => Brand;
}
