using DesignPatterns.Patterns.Strategy.Ducks;

namespace DesignPatterns.Patterns.Strategy.Exercises;

public class StrategyExercises
{
    public StrategyExercises()
    {
        Page2();
    }

    public void Page2()
    {
        var mallardDuck = new MallardDuck();
        var redheadDuck = new RedheadDuck();
    }
}
