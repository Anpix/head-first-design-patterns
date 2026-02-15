using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

namespace DesignPatterns.Patterns.Strategy.Characters;

public class Knight : Character
{
    public Knight() : base("Knight", new SwordBehavior())
    {
    }
}
