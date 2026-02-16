namespace DesignPatterns.Patterns.Decorator.Beverages;

public class Decaf : Beverage
{
    public override string Description { get; set; } = "Decaf Coffee";

    public override float Cost { get; set; } = 1.05f;
}
