using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Stores;

public abstract class PizzaStore
{
    public string Name { get; init; } = "Pizza Store";

    public PizzaStore(string name)
    {
        Name = name;
        LogUtils.Warning($"Creating {Name}...");
    }

    public abstract Pizza CreatePizza(string type);

    public virtual Pizza Order(string type)
    {
        Pizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
