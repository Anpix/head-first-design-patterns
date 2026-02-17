using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Store;

public class SimplePizzaFactory
{
    public SimplePizzaFactory()
    {
        LogUtils.Warning("Creating Simple Pizza Factory...");
    }

    public Pizza CreatePizza(string type)
    {
        Pizza pizza;

        if (type == "cheese")
        {
            pizza = new CheesePizza();
        }
        else if (type == "greek")
        {
            pizza = new GreekPizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new PepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new ClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new VeggiePizza();
        }
        else
        {
            throw new ArgumentException("Invalid pizza type");
        }

        LogUtils.Success($"Creating {pizza.Name}...");

        return pizza;
    }
}
