using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Decorator.Beverages;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Decorator;

public class DecoratorExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Decorator Exercises");
        Page58();
    }

    private static void Page58()
    {
        LogUtils.SubHeader(nameof(Page58));

        var houseBlend = new HouseBlend();
        LogUtils.Info($"Beverage: {houseBlend.Description}, Cost: {houseBlend.Cost:C}");
        var darkRoast = new DarkRoast();
        LogUtils.Info($"Beverage: {darkRoast.Description}, Cost: {darkRoast.Cost:C}");
        var decaf = new Decaf();
        LogUtils.Info($"Beverage: {decaf.Description}, Cost: {decaf.Cost:C}");
        var espresso = new Espresso();
        LogUtils.Info($"Beverage: {espresso.Description}, Cost: {espresso.Cost:C}");

        LogUtils.Footer();
    }
}
