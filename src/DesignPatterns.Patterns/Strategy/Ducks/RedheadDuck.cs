using DesignPatterns.Patterns.Strategy.Behaviors.Fly;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class RedheadDuck : Duck
{
    public RedheadDuck() : base("Redhead", new FlyWithWings()) { }
}
