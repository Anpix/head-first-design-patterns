namespace DesignPatterns.Patterns.Decorator.Beverages;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        BaseDescription = "Dark Roast Coffee";
        BaseCost = 0.99;
    }
}
