namespace DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

public class KnifeBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("I'm using a knife!");
    }
}
