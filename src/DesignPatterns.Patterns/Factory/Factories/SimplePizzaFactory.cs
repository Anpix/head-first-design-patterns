using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Factories;

public abstract class SimplePizzaFactory
{
    public string Name { get; init; } = "Simple Pizza Factory";

    public SimplePizzaFactory(string name)
    {
        Name = name;
        LogUtils.Warning($"Creating {Name}...");
    }

    public virtual Pizza CreatePizza(string type)
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
