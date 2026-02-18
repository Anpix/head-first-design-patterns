using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Stores;

public class NYPizzaStore : PizzaStore
{
    public override string Name => "NY Pizza Store";

    public NYPizzaStore(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }

    protected override Pizza? CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(IngredientsFactory),
            "greek" => new GreekPizza(IngredientsFactory),
            "pepperoni" => new PepperoniPizza(IngredientsFactory),
            "clam" => new ClamPizza(IngredientsFactory),
            "veggie" => new VeggiePizza(IngredientsFactory),
            _ => null,
        };
    }
}
