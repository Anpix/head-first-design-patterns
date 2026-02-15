using DesignPatterns.Patterns.Strategy.Animals;
using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Ducks;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Strategy;

public class StrategyExercises
{
    public StrategyExercises()
    {
        Page8();
        Page9();
        Page15();
    }

    public static void Page8()
    {
        LogUtils.SubHeader("Page 8");

        var mallardDuck = new MallardDuck();
        var redheadDuck = new RedheadDuck();
        var rubberDuck = new RubberDuck();
        var decoyDuck = new DecoyDuck();

        Console.WriteLine();
    }

    public static void Page9()
    {
        LogUtils.SubHeader("Page 9");

        Console.WriteLine("Animal: Dog");
        Animal animalA = new Dog();
        animalA.MakeSound();
        Console.WriteLine("Animal: Cat");
        Animal animalB = new Cat();
        animalB.MakeSound();

        Console.WriteLine();
    }

    public static void Page15()
    {
        LogUtils.SubHeader("Page 15");

        var duck = new ModelDuck();
        duck.SetFlyBehavior(new FlyRocketPowered());
        duck.PerformFly();

        Console.WriteLine();
    }
}
