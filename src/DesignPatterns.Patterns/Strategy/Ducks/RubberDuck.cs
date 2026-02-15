using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck() : base("Rubber Duck", new FlyNoWay(), new Squeak())
    {
    }
}
