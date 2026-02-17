using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class CaliforniaStylePepperoniPizza : PepperoniPizza
{
    public override string Name { get; init; } = "California Style Pepperoni Pizza";
    public override string Dough { get; init; } = "Thin Crust Dough";
    public override string Sauce { get; init; } = "Marinara Sauce";
    public override IList<string> Toppings { get; init; } = ["Shredded Mozzarella Cheese", "Sliced Pepperoni"];

}
