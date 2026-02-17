using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Factory.Styles;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Stores;

public class NYPizzaStore : PizzaStore
{
    public NYPizzaStore() : base("NY Pizza Store")
    {
    }

    public override Pizza CreatePizza(string type)
    {

        Pizza pizza;

        if (type == "cheese")
        {
            pizza = new NYStyleCheesePizza();
        }
        else if (type == "greek")
        {
            pizza = new NYStyleGreekPizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new NYStylePepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new NYStyleClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new NYStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Invalid pizza type");
        }

        LogUtils.Success($"Creating {pizza.Name}...");

        return pizza;
    }
}
