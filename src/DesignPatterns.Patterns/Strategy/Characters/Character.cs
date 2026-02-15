using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Strategy.Characters;

public abstract class Character
{
    public string Name { get; protected set; }
    public IWeaponBehavior WeaponBehavior { get; protected set; }

    public Character(string name, IWeaponBehavior weaponBehavior)
    {
        Name = name;
        WeaponBehavior = weaponBehavior;

        Act();
    }

    public void Act()
    {
        ConsoleUtils.WriteSeparator();
        Console.WriteLine($"I'm the {Name}.");
        PerformWeapon();
        Console.WriteLine();
    }

    public void SetWeaponBehavior(IWeaponBehavior weaponBehavior)
    {
        WeaponBehavior = weaponBehavior;
    }

    public void PerformWeapon()
    {
        WeaponBehavior?.UseWeapon();
    }
}
