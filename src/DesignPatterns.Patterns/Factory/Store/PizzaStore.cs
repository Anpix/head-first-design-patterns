using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Store;

public class PizzaStore
{
    SimplePizzaFactory Factory { get; init; }

    public PizzaStore(SimplePizzaFactory simplePizzaFactory)
    {
        LogUtils.Warning("Creating Pizza Store...");
        Factory = simplePizzaFactory;
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
