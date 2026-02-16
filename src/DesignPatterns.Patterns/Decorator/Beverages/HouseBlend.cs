namespace DesignPatterns.Patterns.Decorator.Beverages;

public class HouseBlend : Beverage
{
    public override string Description { get; set; } = "House Blend Coffee";

    public override float BaseCost { get; set; } = 0.89f;
}
