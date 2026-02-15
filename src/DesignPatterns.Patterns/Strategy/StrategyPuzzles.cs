using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Strategy.Behaviors.Weapons;
using DesignPatterns.Patterns.Strategy.Characters;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Strategy;

public class StrategyPuzzles : Exercise
{
    public override void Run()
    {
        LogUtils.Header("Strategy Puzzles");

        Page25();

        LogUtils.Footer();
    }

    private static void Page25()
    {
        LogUtils.SubHeader("Page 25");

        var king = new King();
        LogUtils.Info("Setting King's weapon behavior to ArrowBehavior...");
        king.SetWeaponBehavior(new ArrowBehavior());
        LogUtils.Info("Performing King's weapon behavior...");
        king.PerformWeapon();

        var queen = new Queen();
        LogUtils.Info("Setting Queen's weapon behavior to SwordBehavior...");
        queen.SetWeaponBehavior(new SwordBehavior());
        LogUtils.Info("Performing Queen's weapon behavior...");
        queen.PerformWeapon();

        var knight = new Knight();
        LogUtils.Info("Setting Knight's weapon behavior to AxeBehavior...");
        knight.SetWeaponBehavior(new AxeBehavior());
        LogUtils.Info("Performing Knight's weapon behavior...");
        knight.PerformWeapon();

        var troll = new Troll();
        LogUtils.Info("Setting Troll's weapon behavior to SwordBehavior...");
        troll.SetWeaponBehavior(new SwordBehavior());
        LogUtils.Info("Performing Troll's weapon behavior...");
        troll.PerformWeapon();

        LogUtils.Footer();
    }
}
