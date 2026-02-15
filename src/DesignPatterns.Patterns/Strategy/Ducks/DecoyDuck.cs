namespace DesignPatterns.Patterns.Strategy.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck() : base("Decoy") { }

    public override void Quack()

    {
        Console.WriteLine($"{Name} cannot quack.");
    }

    public override void Fly()
    {
        Console.WriteLine($"{Name} cannot fly.");
    }
}
