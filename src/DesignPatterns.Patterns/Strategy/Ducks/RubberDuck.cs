using DesignPatterns.Patterns.Strategy.Behaviors.Fly;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck() : base("Rubber", new FlyNoWay()) { }

    public override void Quack()
    {
        Console.WriteLine($"I'm squeaking!");
    }
}
