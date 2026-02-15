using DesignPatterns.Patterns.Strategy.Behaviors.Fly;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck() : base("Mallard", new FlyWithWings()) { }
}
