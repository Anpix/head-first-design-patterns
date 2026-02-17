using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Styles;

public class ChicagoStyleClamPizza : ClamPizza
{
    public override string Name { get; init; } = "Chicago Style Deep Dish Clam Pizza";
    public override string Dough { get; init; } = "Extra Thick Crust Dough";
    public override string Sauce { get; init; } = "White Garlic Sauce";
    public override IList<string> Toppings { get; init; } = ["Fresh Clams", "Shredded Mozzarella Cheese"];

}
