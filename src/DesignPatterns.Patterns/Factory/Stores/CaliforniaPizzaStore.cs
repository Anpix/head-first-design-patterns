using DesignPatterns.Patterns.Factory.Pizzas;
using DesignPatterns.Patterns.Factory.Styles;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Stores;

public class CaliforniaPizzaStore : PizzaStore
{
    public CaliforniaPizzaStore() : base("California Pizza Store")
    {
    }

    public override Pizza CreatePizza(string type)
    {

        Pizza pizza;

        if (type == "cheese")
        {
            pizza = new CaliforniaStyleCheesePizza();
        }
        else if (type == "greek")
        {
            pizza = new CaliforniaStyleGreekPizza();
        }
        else if (type == "pepperoni")
        {
            pizza = new CaliforniaStylePepperoniPizza();
        }
        else if (type == "clam")
        {
            pizza = new CaliforniaStyleClamPizza();
        }
        else if (type == "veggie")
        {
            pizza = new CaliforniaStyleVeggiePizza();
        }
        else
        {
            throw new ArgumentException("Invalid pizza type");
        }

        LogUtils.Success($"Creating {pizza.Name}...");

        return pizza;
    }
}
