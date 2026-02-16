using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Decorator.Beverages;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Decorator;

public class DecoratorExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Decorator Exercises");
        Page60();
    }

    private static void Page60()
    {
        LogUtils.SubHeader(nameof(Page60));

        var houseBlend = new HouseBlend();
        LogUtils.Info(houseBlend.Details());
        var darkRoast = new DarkRoast();
        LogUtils.Info(darkRoast.Details());
        var decaf = new Decaf();
        LogUtils.Info(decaf.Details());
        var espresso = new Espresso();
        LogUtils.Info(espresso.Details());

        LogUtils.Footer();
    }
}
