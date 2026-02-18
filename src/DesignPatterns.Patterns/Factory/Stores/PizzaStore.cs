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

    protected abstract Pizza? CreatePizza(string type);

    public virtual void Order(string type)
    {
        LogUtils.Important($"Ordering a {type} pizza from {Name}...");

        var pizza = CreatePizza(type);
        if (pizza == null)
        {
            LogUtils.Error($"Sorry, we don't have this type of pizza ({type}) in {Name}.");
            return;
        }

        pizza.Describe();
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }
}
