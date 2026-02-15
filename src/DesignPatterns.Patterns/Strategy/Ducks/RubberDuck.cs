namespace DesignPatterns.Patterns.Strategy.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck() : base("Rubber") { }

    public override void Quack()
    {
        Console.WriteLine($"{Name} is squeaking!");
    }

    public override void Fly()
    {
        Console.WriteLine($"{Name} cannot fly.");
    }
}
