using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Stores;

public abstract class PizzaStore
{
    public abstract string Name { get; }
    protected IPizzaIngredientsFactory IngredientsFactory { get; init; }

    public PizzaStore(IPizzaIngredientsFactory ingredientsFactory)
    {
        IngredientsFactory = ingredientsFactory;
        LogUtils.Warning($"Creating {Name}...");
    }



    public virtual Pizza CreatePizza(string type)
    {
        if (type == "cheese")
        {
            return new CheesePizza(IngredientsFactory);
        }
        else if (type == "greek")
        {
            return new GreekPizza(IngredientsFactory);
        }
        else if (type == "pepperoni")
        {
            return new PepperoniPizza(IngredientsFactory);
        }
        else if (type == "clam")
        {
            return new ClamPizza(IngredientsFactory);
        }
        else if (type == "veggie")
        {
            return new VeggiePizza(IngredientsFactory);
        }
        else
        {
            throw new ArgumentException("Invalid pizza type");
        }
    }

    public virtual Pizza Order(string type)
    {
        LogUtils.Important($"Ordering a {type} pizza from {Name}...");
        Pizza pizza = CreatePizza(type);

        pizza.Describe();
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
