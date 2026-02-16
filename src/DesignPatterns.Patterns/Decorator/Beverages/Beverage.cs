namespace DesignPatterns.Patterns.Decorator.Beverages;

public abstract class Beverage
{
    public abstract string Description { get; set; }

    public bool Milk { get; set; }
    public bool Soy { get; set; }
    public bool Mocha { get; set; }
    public bool Whip { get; set; }

    public abstract float BaseCost { get; set; }

    public float Cost()
    {
        var cost = BaseCost;
        if (Milk) cost += 0.10f;
        if (Soy) cost += 0.15f;
        if (Mocha) cost += 0.20f;
        if (Whip) cost += 0.25f;
        return cost;
    }

    public string Details()
    {
        return $"Beverage: {Description}, Condiments: {(Milk ? "+Milk " : "")}{(Soy ? "+Soy " : "")}{(Mocha ? "+Mocha " : "")}{(Whip ? "+Whip " : "")}{(!Milk && !Soy && !Mocha && !Whip ? "None" : "")}, Cost: {Cost():C}";
    }
}
