namespace DesignPatterns.Patterns.Decorator.Beverages;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        BaseDescription = "House Blend Coffee";
        BaseCost = 0.89;
    }
}
