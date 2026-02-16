namespace DesignPatterns.Patterns.Decorator.Beverages;

public class DarkRoast : Beverage
{
    public override string Description { get; set; } = "Dark Roast Coffee";

    public override float BaseCost { get; set; } = 0.99f;
}
