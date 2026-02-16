using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Decorator.Beverages;
using DesignPatterns.Patterns.Decorator.Condiments;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Decorator;

public class DecoratorExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Decorator Exercises");
        Page60();
        Page71();
    }

    private static void Page60()
    {
        LogUtils.SubHeader(nameof(Page60));

        var houseBlend = new HouseBlend();
        LogUtils.Info(houseBlend.Description);
        var darkRoast = new DarkRoast();
        LogUtils.Info(darkRoast.Description);
        var decaf = new Decaf();
        LogUtils.Info(decaf.Description);
        var espresso = new Espresso();
        LogUtils.Info(espresso.Description);

        LogUtils.Footer();
    }

    private static void Page71()
    {
        LogUtils.SubHeader(nameof(Page71));

        LogUtils.Success("Creating a DarkRoast...");
        var beverage1 = new DarkRoast();
        LogUtils.Info($"Beverage 1: {beverage1.Description} = {beverage1.Cost:C}");
        var beverage2 = new Mocha(beverage1);
        LogUtils.Info($"Beverage 2: {beverage2.Description} = {beverage2.Cost:C}");
        var beverage3 = new Mocha(beverage2);
        LogUtils.Info($"Beverage 3: {beverage3.Description} = {beverage3.Cost:C}");
        var beverage4 = new Whip(beverage3);
        LogUtils.Info($"Beverage 4: {beverage4.Description} = {beverage4.Cost:C}");
        LogUtils.Footer();

        LogUtils.Success("Creating a HouseBlend...");
        var beverageA = new HouseBlend();
        LogUtils.Info($"Beverage A: {beverageA.Description} = {beverageA.Cost:C}");
        var beverageB = new Soy(beverageA);
        LogUtils.Info($"Beverage B: {beverageB.Description} = {beverageB.Cost:C}");
        var beverageC = new Mocha(beverageB);
        LogUtils.Info($"Beverage C: {beverageC.Description} = {beverageC.Cost:C}");
        var beverageD = new Whip(beverageC);
        LogUtils.Info($"Beverage D: {beverageD.Description} = {beverageD.Cost:C}");
        LogUtils.Footer();
    }
}
