using DesignPatterns.Patterns.Decorator.Beverages;

namespace DesignPatterns.Patterns.Decorator.Condiments;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
        BaseDescription = "Whip";
        BaseCost = 0.25;
    }
}
