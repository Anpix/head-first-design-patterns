using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Ingredients;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public class ClamPizza : Pizza
{
    public override string Name => "Clam Pizza";

    public ClamPizza(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
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
            IngredientsFactory.CreateClam(),
        };

        ingredients.AddRange(IngredientsFactory.CreateVeggies());
        Ingredients = ingredients;
    }
}
