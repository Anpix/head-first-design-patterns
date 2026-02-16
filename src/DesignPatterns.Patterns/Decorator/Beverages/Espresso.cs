namespace DesignPatterns.Patterns.Decorator.Beverages;

public class Espresso : Beverage
{
    public Espresso()
    {
        BaseDescription = "Espresso Coffee";
        BaseCost = 1.99;
    }
}
