using DesignPatterns.Patterns.Decorator.Beverages;

namespace DesignPatterns.Patterns.Decorator.Condiments;

public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
        BaseDescription = "Milk";
        BaseCost = 0.10;
    }
}
