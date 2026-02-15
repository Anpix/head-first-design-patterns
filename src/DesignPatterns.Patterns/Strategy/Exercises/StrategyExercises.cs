using DesignPatterns.Patterns.Strategy.Ducks;

namespace DesignPatterns.Patterns.Strategy.Exercises;

public class StrategyExercises
{
    public StrategyExercises()
    {
        Page4();
    }

    public static void Page4()
    {
        var mallardDuck = new MallardDuck();
        var redheadDuck = new RedheadDuck();
        var rubberDuck = new RubberDuck();
        var decoyDuck = new DecoyDuck();
    }
}
