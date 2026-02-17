using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public class CheesePizza : Pizza
{
    public override string Name => "Cheese Pizza";

    public CheesePizza(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }

    public override void Prepare()
    {
        LogUtils.Warning($"Preparing {Name}...");
        Dough = IngredientsFactory.CreateDough();
        Sauce = IngredientsFactory.CreateSauce();
        Cheese = IngredientsFactory.CreateCheese();
        Meat = IngredientsFactory.CreateMeat();
        Clam = IngredientsFactory.CreateClam();
        Veggies = IngredientsFactory.CreateVeggies();
    }
}
