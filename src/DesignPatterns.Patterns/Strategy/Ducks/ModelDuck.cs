using DesignPatterns.Patterns.Strategy.Behaviors.Fly;
using DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

namespace DesignPatterns.Patterns.Strategy.Ducks;

public class ModelDuck : Duck
{
    public ModelDuck() : base("Model Duck", new FlyNoWay(), new MuteQuack())
    {
    }
}
