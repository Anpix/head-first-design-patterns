using DesignPatterns.Patterns.Strategy.Animals;
using DesignPatterns.Patterns.Strategy.Ducks;

namespace DesignPatterns.Patterns.Strategy.Exercises;

public class StrategyExercises
{
    public StrategyExercises()
    {
        Page9();
    }

    public static void Page9()
    {
        var mallardDuck = new MallardDuck();
        var redheadDuck = new RedheadDuck();
        var rubberDuck = new RubberDuck();
        var decoyDuck = new DecoyDuck();

        Console.WriteLine("-----");
        Console.WriteLine("Animal: Dog");
        Animal animalA = new Dog();
        animalA.MakeSound();
        Console.WriteLine("Animal: Cat");
        Animal animalB = new Cat();
        animalB.MakeSound();
    }
}
