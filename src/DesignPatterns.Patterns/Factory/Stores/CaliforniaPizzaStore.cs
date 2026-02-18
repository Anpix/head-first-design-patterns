using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Stores;

public class CaliforniaPizzaStore : PizzaStore
{
    public override string Name => "California Pizza Store";

    public CaliforniaPizzaStore(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }

    protected override Pizza? CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(IngredientsFactory),
            "pepperoni" => new PepperoniPizza(IngredientsFactory),
            "veggie" => new VeggiePizza(IngredientsFactory),
            _ => null,
        };
    }
}
