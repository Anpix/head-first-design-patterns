namespace DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

public class SwordBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("I'm using a sword!");
    }
}
