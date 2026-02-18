using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Singleton.ChocolateFactory;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Singleton;

public class SingletonExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Singleton Exercises");
        Page130();
    }

    private static void Page130()
    {
        LogUtils.SubHeader(nameof(Page130));

        LogUtils.Important("Creating an instance of ChocolateBoiler...");
        var boiler1 = ChocolateBoiler.GetInstance();
        boiler1.Fill();
        boiler1.Boil();
        boiler1.Drain();
        LogUtils.EmptyLine();

        LogUtils.Important("Trying to create another instance of ChocolateBoiler...");
        var boiler2 = ChocolateBoiler.GetInstance();
        LogUtils.Info($"Are boiler1 and boiler2 the same instance? {ReferenceEquals(boiler1, boiler2)}");
        LogUtils.EmptyLine();

        LogUtils.Important("Filling boiler1 and boiler2...");
        boiler1.Fill();
        boiler2.Fill();
        LogUtils.EmptyLine();

        LogUtils.Important("Boiling boiler1 and boiler2...");
        boiler1.Boil();
        boiler2.Boil();
        LogUtils.EmptyLine();

        LogUtils.Important("Draining boiler1 and boiler2...");
        boiler1.Drain();
        boiler2.Drain();

        LogUtils.Footer();
    }
}
