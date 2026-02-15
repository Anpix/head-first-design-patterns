using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

namespace DesignPatterns.Patterns.Strategy.Characters;

public class King : Character
{
    public King() : base("King", new SwordBehavior())
    {
    }
}
