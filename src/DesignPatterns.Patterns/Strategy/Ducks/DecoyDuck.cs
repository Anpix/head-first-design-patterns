using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck() : base("Decoy", new FlyNoWay(), new MuteQuack())
    {
    }
}
