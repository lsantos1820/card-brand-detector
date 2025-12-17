using CardBrandDetector.Src.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var detector = new CardBrandDetectorService();

Console.WriteLine("=== 💳 Card Brand Detector (Regex + C#) ===\n");
Console.WriteLine("Digite o número do cartão (pode usar espaços ou hífens).");
Console.WriteLine("Digite 0 para sair.\n");

while (true)
{
    Console.Write("Cartão: ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Entrada vazia. Tente novamente.\n");
        continue;
    }

    if (input.Trim() == "0")
        break;

    var result = detector.Detect(input);
    Console.WriteLine($"Bandeira detectada: {result}\n");
}

Console.WriteLine("Encerrado.");
