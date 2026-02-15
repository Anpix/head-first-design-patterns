using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public abstract class Duck
{
    public string Name { get; protected set; }
    public IFlyBehavior FlyBehavior { get; protected set; }
    public IQuackBehavior QuackBehavior { get; protected set; }

    public Duck(string name, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        Name = name;
        FlyBehavior = flyBehavior;
        QuackBehavior = quackBehavior;

        Act();
    }

    public void Act()
    {
        ConsoleUtils.WriteSeparator();
        Console.WriteLine($"My name is {Name}.");
        PerformQuack();
        Swim();
        PerformFly();
        Display();
        Console.WriteLine();
    }

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        FlyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        QuackBehavior = quackBehavior;
    }

    public void PerformQuack()
    {
        QuackBehavior?.Quack();
    }

    public void PerformFly()
    {
        FlyBehavior?.Fly();
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
