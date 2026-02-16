using DesignPatterns.Patterns.Decorator.Beverages;

namespace DesignPatterns.Patterns.Decorator.Condiments;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
        BaseDescription = "Soy";
        BaseCost = 0.15;
    }
}
