using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.ConsoleApp.Handlers;

public static class MainMenuHandler
{
    public static void MainMenu()
    {
        ConsoleUtils.Clear();
        LogUtils.Header("Design Patterns Console App");
        LogOptions();
        InputHandler.ReadInput();
    }

    public static void LogOptions()
    {
        ConsoleUtils.WriteInfo("Options:");
        ConsoleUtils.WriteInfo("0. Exit");
        ConsoleUtils.WriteInfo("1. Strategy");
    }
}
