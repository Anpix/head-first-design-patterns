namespace DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

public class ArrowBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("I'm using an arrow!");
    }
}
