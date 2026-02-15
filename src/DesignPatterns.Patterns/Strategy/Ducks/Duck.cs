namespace DesignPatterns.Patterns.Strategy.Ducks;

public abstract class Duck
{
    public string Name { get; protected set; }

    public Duck(string name)
    {
        this.Name = $"{name} Duck";

        this.Quack();
        this.Swim();
        this.Fly();
        this.Display();
    }

    public virtual void Quack()
    {
        Console.WriteLine($"{Name} is quacking.");
    }

    public virtual void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }

    public virtual void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }

    public virtual void Display()
    {
        Console.WriteLine($"Looks like a {Name}.");
    }
}
