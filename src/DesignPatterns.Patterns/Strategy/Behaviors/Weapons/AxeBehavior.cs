namespace DesignPatterns.Patterns.Strategy.Behaviors.Weapons;

public class AxeBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("I'm using an axe!");
    }
}
