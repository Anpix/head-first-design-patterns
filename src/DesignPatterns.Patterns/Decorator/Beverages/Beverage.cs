namespace DesignPatterns.Patterns.Decorator.Beverages;

public abstract class Beverage
{
    protected string BaseDescription { get; init; } = "Unknown Beverage";
    protected double BaseCost { get; init; } = 0.0;

    public virtual string Description => BaseDescription;
    public virtual double Cost => BaseCost;
}
