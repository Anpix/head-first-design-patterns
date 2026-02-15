using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck() : base("Mallard", new FlyWithWings(), new Quack())
    {
    }
}
