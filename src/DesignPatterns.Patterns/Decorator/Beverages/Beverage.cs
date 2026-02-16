namespace DesignPatterns.Patterns.Decorator.Beverages;

public abstract class Beverage
{
    public abstract string Description { get; set; }

    public abstract float Cost { get; set; }
}
