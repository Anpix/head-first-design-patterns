using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class NYStyleGreekPizza : GreekPizza
{
    public override string Name { get; init; } = "NY Style Greek Pizza";
    public override string Dough { get; init; } = "Thin Crust Dough";
    public override string Sauce { get; init; } = "Marinara Sauce";
    public override IList<string> Toppings { get; init; } = ["Feta Cheese", "Olives", "Onions", "Tomatoes"];

}
