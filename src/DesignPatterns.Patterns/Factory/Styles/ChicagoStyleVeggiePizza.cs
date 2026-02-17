using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class ChicagoStyleVeggiePizza : VeggiePizza
{
    public override string Name { get; init; } = "Chicago Style Deep Dish Veggie Pizza";
    public override string Dough { get; init; } = "Extra Thick Crust Dough";
    public override string Sauce { get; init; } = "Plum Tomato Sauce";
    public override IList<string> Toppings { get; init; } = ["Bell Peppers", "Mushrooms", "Onions", "Olives", "Eggplant", "Spinach"];
}
