using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Ingredients;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public class PepperoniPizza : Pizza
{
    public override string Name => "Pepperoni Pizza";

    public PepperoniPizza(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }

    public override void Prepare()
    {
        LogUtils.Info($"Preparing {Name}");
        var ingredients = new List<Ingredient>
        {
            IngredientsFactory.CreateDough(),
            IngredientsFactory.CreateSauce(),
            IngredientsFactory.CreateCheese(),
        };

        ingredients.AddRange(IngredientsFactory.CreateMeats());
        ingredients.AddRange(IngredientsFactory.CreateVeggies());
        Ingredients = ingredients;

    }
}
