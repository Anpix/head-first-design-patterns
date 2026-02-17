using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class CaliforniaStyleVeggiePizza : VeggiePizza
{
    public override string Name { get; init; } = "California Style Veggie Pizza";
    public override string Dough { get; init; } = "Thin Crust Dough";
    public override string Sauce { get; init; } = "Marinara Sauce";
    public override IList<string> Toppings { get; init; } = ["Bell Peppers", "Mushrooms", "Onions", "Olives", "Tomatoes"];

}
