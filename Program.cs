string[] names = ["Zoltan", "Fanni"];

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"Hello {string.Join(", ", names[..^1])} and {names[^1]}!");

Console.WriteLine("this is a new line");


Console.ResetColor();

while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;