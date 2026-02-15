namespace DesignPatterns.Patterns.Utils;

public static class ConsoleUtils
{

    public static void WriteCustomHeader(string title, char character)
    {
        var startEnd = new string(character, 2);
        var fullTitle = $"{startEnd} {title} {startEnd}";

        Console.WriteLine();
        WriteSeparator(character, fullTitle.Length);
        Console.WriteLine(fullTitle);
        WriteSeparator(character, fullTitle.Length);
        Console.WriteLine();
    }

    public static void WriteSeparator(char character = '-', int length = 20)
    {
        Console.WriteLine(new string(character, length));
    }

    public static void PauseBreak()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
}