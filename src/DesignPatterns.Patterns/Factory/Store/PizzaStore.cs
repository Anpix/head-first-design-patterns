using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Store;

public class PizzaStore
{
    public virtual Pizza Order()
    {
        var pizza = new Pizza();

        LogUtils.Success($"Creating {pizza.Name}...");

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        LogUtils.EmptyLine();

        return pizza;
    }
}
