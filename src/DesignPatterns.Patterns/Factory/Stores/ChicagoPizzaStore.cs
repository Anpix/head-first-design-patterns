using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Pizzas;

namespace DesignPatterns.Patterns.Factory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    public override string Name => "Chicago Pizza Store";

    public ChicagoPizzaStore(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }

    protected override Pizza? CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(IngredientsFactory),
            "pepperoni" => new PepperoniPizza(IngredientsFactory),
            "clam" => new ClamPizza(IngredientsFactory),
            "veggie" => new VeggiePizza(IngredientsFactory),
            _ => null,
        };
    }
}
