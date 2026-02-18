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
        ConsoleUtils.WriteInfo("2. Observer");
        ConsoleUtils.WriteInfo("3. Decorator");
        ConsoleUtils.WriteInfo("4. Factory");
        ConsoleUtils.WriteInfo("5. Singleton");
    }
}
