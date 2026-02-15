using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

namespace DesignPatterns.Patterns.Strategy.Characters;

public class Troll : Character
{
    public Troll() : base("Troll", new KnifeBehavior())
    {
    }
}
