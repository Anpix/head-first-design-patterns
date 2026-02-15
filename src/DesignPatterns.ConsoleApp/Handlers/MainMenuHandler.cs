using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.ConsoleApp.Handlers;

public static class MainMenuHandler
{
    public static void MainMenu()
    {
        Console.Clear();
        LogUtils.Header("Design Patterns Console App");
        LogOptions();
        InputHandler.ReadInput();
    }

    public static void LogOptions()
    {
        Console.WriteLine("Options:");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Strategy");
    }
}
