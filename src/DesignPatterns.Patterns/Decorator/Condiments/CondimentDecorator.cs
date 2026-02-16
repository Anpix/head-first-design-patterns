using DesignPatterns.Patterns.Decorator.Beverages;

namespace DesignPatterns.Patterns.Decorator.Condiments;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage { get; init; }

    protected CondimentDecorator(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override string Description => $"{Beverage.Description} + {BaseDescription}";
    public override double Cost => Beverage.Cost + BaseCost;
}
