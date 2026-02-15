namespace DesignPatterns.Patterns.Utils;

public static class ConsoleUtils
{
    public static void Clear()
    {
        Console.Clear();
    }

    public static void Empty()
    {
        Console.WriteLine();
    }

    public static void PauseBreak(string? message = null)
    {
        ConsoleUtils.Empty();
        ConsoleUtils.WriteInfo(message ?? "Press any key to return to menu...");
        Console.ReadKey();
    }

    public static void WriteCustomHeader(string title, char character = '#')
    {
        var startEnd = new string(character, 2);
        var fullTitle = $"{startEnd} {title} {startEnd}";

        ConsoleUtils.Empty();
        WriteSeparator(character, fullTitle.Length);
        ConsoleUtils.WriteInfo(fullTitle);
        WriteSeparator(character, fullTitle.Length);
        ConsoleUtils.Empty();
    }

    public static void WriteSeparator(char character = '-', int length = 20)
    {
        ConsoleUtils.WriteInfo(new string(character, length));
    }

    public static string ReadInput(string prompt = "")
    {
        if (!string.IsNullOrWhiteSpace(prompt))
        {
            Console.Write(prompt);
        }
        return Console.ReadLine() ?? string.Empty;
    }

    public static void WriteInfo(string message)
    {
        Console.WriteLine(message);
    }

    public static void WriteColor(string message, ConsoleColor color)
    {
        var colorBkp = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = colorBkp;
    }
}