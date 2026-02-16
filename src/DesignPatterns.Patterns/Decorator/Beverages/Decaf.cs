namespace DesignPatterns.Patterns.Decorator.Beverages;

public class Decaf : Beverage
{
    public Decaf()
    {
        BaseDescription = "Decaf Coffee";
        BaseCost = 1.05;
    }
}
