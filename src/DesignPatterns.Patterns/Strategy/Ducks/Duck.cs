using DesignPatterns.Patterns.Strategy.Behaviors.Fly;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public abstract class Duck
{
    public string Name { get; protected set; }
    public IFlyBehavior? FlyBehavior { get; protected set; }

    public Duck(string name, IFlyBehavior? flyBehavior = null)
    {
        Name = $"{name} Duck";
        FlyBehavior = flyBehavior;

        Act();
    }

    public void Act()
    {
        Console.WriteLine($"-----");
        Console.WriteLine($"My name is {Name}.");
        Quack();
        Swim();
        FlyBehavior?.Fly();
        Display();
    }

    public virtual void Quack()
    {
        Console.WriteLine($"I'm quacking.");
    }

    public virtual void Swim()
    {
        Console.WriteLine($"I'm swimming.");
    }

    public virtual void Display()
    {
        Console.WriteLine($"I look like a {Name}.");

    }
}
