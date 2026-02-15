using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Strategy.Animals;
using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Ducks;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Strategy;

public class StrategyExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Strategy Exercises");

        Page8();
        Page9();
        Page15();
    }

    private static void Page8()
    {
        LogUtils.SubHeader("Page 8");

        var mallardDuck = new MallardDuck();
        var redheadDuck = new RedheadDuck();
        var rubberDuck = new RubberDuck();
        var decoyDuck = new DecoyDuck();

        LogUtils.Footer();
    }

    private static void Page9()
    {
        LogUtils.SubHeader("Page 9");

        Console.WriteLine("Animal: Dog");
        Animal animalA = new Dog();
        animalA.MakeSound();

        Console.WriteLine("Animal: Cat");
        Animal animalB = new Cat();
        animalB.MakeSound();

        LogUtils.Footer();
    }

    private static void Page15()
    {
        LogUtils.SubHeader("Page 15");

        var duck = new ModelDuck();
        LogUtils.Info("Setting ModelDuck's fly behavior to FlyRocketPowered...");
        duck.SetFlyBehavior(new FlyRocketPowered());
        LogUtils.Info("Performing ModelDuck's fly behavior...");
        duck.PerformFly();

        LogUtils.Footer();
    }
}
