using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class ChicagoStylePepperoniPizza : PepperoniPizza
{
    public override string Name { get; init; } = "Chicago Style Deep Dish Pepperoni Pizza";
    public override string Dough { get; init; } = "Extra Thick Crust Dough";
    public override string Sauce { get; init; } = "Plum Tomato Sauce";
    public override IList<string> Toppings { get; init; } = ["Shredded Mozzarella Cheese", "Black Olives", "Spinach", "Eggplant", "Sliced Pepperoni"];

}
