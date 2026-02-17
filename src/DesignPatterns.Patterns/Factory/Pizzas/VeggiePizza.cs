using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public class VeggiePizza : Pizza
{
    public override string Name => "Veggie Pizza";

    public VeggiePizza(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }

    public override void Prepare()
    {
        LogUtils.Info($"Preparing {Name}");
        Dough = IngredientsFactory.CreateDough();
        Sauce = IngredientsFactory.CreateSauce();
        Cheese = IngredientsFactory.CreateCheese();
        Meat = IngredientsFactory.CreateMeat();
        Clam = IngredientsFactory.CreateClam();
        Veggies = IngredientsFactory.CreateVeggies();
    }
}
