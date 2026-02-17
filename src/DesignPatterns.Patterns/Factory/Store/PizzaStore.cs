using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Store;

public class PizzaStore
{
    SimplePizzaFactory Factory { get; init; }

    public PizzaStore(SimplePizzaFactory simplePizzaFactory)
    {
        Factory = simplePizzaFactory;
        LogUtils.Warning($"Creating Pizza Store with {Factory.Name}...");
    }

    public virtual Pizza Order(string type)
    {
        Pizza pizza = Factory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
