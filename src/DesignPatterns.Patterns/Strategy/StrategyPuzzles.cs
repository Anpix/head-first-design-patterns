using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;
using DesignPatterns.Patterns.Strategy.Characters;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Strategy;

public class PuzzleExercises
{
    public PuzzleExercises()
    {
        Page25();
    }

    public static void Page25()
    {
        LogUtils.Header("Page 25");

        var king = new King();
        king.SetWeaponBehavior(new ArrowBehavior());
        king.PerformWeapon();

        var queen = new Queen();
        queen.SetWeaponBehavior(new SwordBehavior());
        queen.PerformWeapon();

        var knight = new Knight();
        knight.SetWeaponBehavior(new AxeBehavior());
        knight.PerformWeapon();

        var troll = new Troll();
        troll.SetWeaponBehavior(new SwordBehavior());
        troll.PerformWeapon();

        Console.WriteLine();
    }
}
