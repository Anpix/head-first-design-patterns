using DesignPatterns.Patterns.Decorator.Beverages;

namespace DesignPatterns.Patterns.Decorator.Condiments;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
        BaseDescription = "Mocha";
        BaseCost = 0.20;
    }
}
