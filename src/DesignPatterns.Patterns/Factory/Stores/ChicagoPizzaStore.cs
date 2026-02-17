using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Factory.Styles;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    public ChicagoPizzaStore() : base("Chicago Pizza Store")
    {
    }

    public override Pizza CreatePizza(string type)
    {

        Pizza pizza;

        if (type == "cheese")
        {
            pizza = new ChicagoStyleCheesePizza();
        }
        else if (type == "greek")
        {
            pizza = new ChicagoStyleGreekPizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new ChicagoStylePepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new ChicagoStyleClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new ChicagoStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Invalid pizza type");
        }

        LogUtils.Success($"Creating {pizza.Name}...");

        return pizza;
    }
}
