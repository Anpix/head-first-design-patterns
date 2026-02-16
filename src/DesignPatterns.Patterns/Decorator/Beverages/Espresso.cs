namespace DesignPatterns.Patterns.Decorator.Beverages;

public class Espresso : Beverage
{
    public override string Description { get; set; } = "Espresso Coffee";

    public override float BaseCost { get; set; } = 1.99f;
}
