using DesignPatterns.ConsoleApp.Enums;
using DesignPatterns.Patterns.Observer;
using DesignPatterns.Patterns.Strategy;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.ConsoleApp.Handlers;

public static class ExercisesHandler
{
    public static void HandleCommand(CommandEnum command)
    {
        ConsoleUtils.Clear();
        switch (command)
        {
            case CommandEnum.STRATEGY:
                StrategyExercises.Run();
                StrategyPuzzles.Run();
                break;
            case CommandEnum.OBSERVER:
                ObserverExercises.Run();
                break;
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
