using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Factory.Store;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory;

public class FactoryExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Factory Exercises");
        Page82();
    }

    private static void Page82()
    {
        LogUtils.SubHeader(nameof(Page82));

        LogUtils.Footer();
    }
}
