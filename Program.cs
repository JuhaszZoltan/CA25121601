string[] names = ["Zoltan", "Fanni"];

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"Hello {string.Join(", ", names[..^1])} and {names[^1]}!");

Console.WriteLine("tis is a new line");


Console.ResetColor();

while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;