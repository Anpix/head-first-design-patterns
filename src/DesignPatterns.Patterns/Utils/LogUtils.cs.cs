namespace DesignPatterns.Patterns.Utils;

public static class LogUtils
{
    public static void Header(string title, char character = '#')
    {
        ConsoleUtils.WriteCustomHeader(title, character);
        EmptyLine();
    }

    public static void SubHeader(string title, char character = '=')
    {
        ConsoleUtils.WriteCustomHeader(title, character);
        EmptyLine();
    }

    public static void Footer()
    {
        EmptyLine();
        EmptyLine();
    }

    public static void EmptyLine()
    {
        ConsoleUtils.Empty();
    }

    public static void Info(string message)
    {
        ConsoleUtils.WriteInfo(message);
    }

    public static void Success(string message)
    {
        ConsoleUtils.WriteColor(message, ConsoleColor.Green);
    }

    public static void Warning(string message)
    {
        ConsoleUtils.WriteColor(message, ConsoleColor.Yellow);
    }

    public static void Error(string message)
    {
        ConsoleUtils.WriteColor(message, ConsoleColor.Red);
    }
}
