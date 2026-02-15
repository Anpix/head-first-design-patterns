using DesignPatterns.Patterns.Strategy.Behaviors.Fly;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck() : base("Decoy", new FlyNoWay()) { }

    public override void Quack()

    {
        Console.WriteLine($"I can't quack.");
    }
}
