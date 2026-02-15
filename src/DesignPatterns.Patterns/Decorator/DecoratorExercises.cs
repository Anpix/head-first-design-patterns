using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Decorator;

public class DecoratorExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Decorator Exercises");
        PageX();
        LogUtils.Footer();
    }

    private static void PageX()
    {
        LogUtils.SubHeader("Page X");


        LogUtils.Footer();
    }
}
