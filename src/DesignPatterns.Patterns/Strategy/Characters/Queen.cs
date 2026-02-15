using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

namespace DesignPatterns.Patterns.Strategy.Characters;

public class Queen : Character
{
    public Queen() : base("Queen", new ArrowBehavior())
    {
    }
}
