namespace DesignPatterns.Patterns.Strategy.Ducks;

public abstract class Duck
{
    public string Name { get; protected set; }

    public Duck(string name)
    {
        Name = $"{name} Duck";

        Act();
    }

    public void Act()
    {
        Console.WriteLine($"-----");
        Console.WriteLine($"My name is {Name}.");
        Quack();
        Swim();
        Fly();
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

    public virtual void Fly()
    {
        Console.WriteLine($"I'm flying.");
    }

    public virtual void Display()
    {
        Console.WriteLine($"I look like a {Name}.");

    }
}
