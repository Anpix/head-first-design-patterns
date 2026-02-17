using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class NYStyleClamPizza : ClamPizza
{
    public override string Name { get; init; } = "NY Style Clam Pizza";
    public override string Dough { get; init; } = "Thin Crust Dough";
    public override string Sauce { get; init; } = "White Garlic Sauce";
    public override IList<string> Toppings { get; init; } = ["Fresh Clams", "Grated Reggiano Cheese"];

}
