namespace DesignPatterns.Patterns.Utils;

public static class LogUtils
{
    public static void Header(string title, char character = '#')
    {
        ConsoleUtils.WriteCustomHeader(title, character);
        Console.WriteLine();
    }

    public static void SubHeader(string title, char character = '=')
    {
        ConsoleUtils.WriteCustomHeader(title, character);
        Console.WriteLine();
    }

    public static void Error(string error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(error);
        Console.ResetColor();
    }
}
