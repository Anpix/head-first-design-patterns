using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class RedheadDuck : Duck
{
    public RedheadDuck() : base("Redhead Duck", new FlyWithWings(), new Quack())
    {
    }
}
