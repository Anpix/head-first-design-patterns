using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.ConsoleApp.Handlers;

public static class ExercisesHandler
{
    public static void HandleCommand(CommandEnum command)
    {
        Console.Clear();
        switch (command)
        {
            case CommandEnum.EXIT:
                Environment.Exit(0);
                break;
            default:
                LogUtils.Error("Unknown command.");
                break;
        }
        ConsoleUtils.PauseBreak();
    }
}
