using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Ingredients;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public abstract class Pizza
{
    public IPizzaIngredientsFactory IngredientsFactory { get; init; }
    public abstract string Name { get; }
    public IList<Ingredient> Ingredients { get; set; } = [];

    public Pizza(IPizzaIngredientsFactory ingredientsFactory)
    {
        IngredientsFactory = ingredientsFactory;
    }

    public abstract void Prepare();

    public virtual void Bake()
    {
        LogUtils.Info($"Bake {Name} for 25 minutes at 350ºC...");
    }

    public virtual void Cut()
    {
        LogUtils.Info($"Cut {Name} into diagonal slices...");
    }

    public virtual void Box()
    {
        LogUtils.Info($"Place {Name} in official PizzaStore box...");
    }

    public void Describe()
    {
        LogUtils.Warning($"Ingredients for {Name}...");
        foreach (var ingredient in Ingredients)
        {
            LogUtils.Info($"- {ingredient.GetType().Name}: {ingredient.Name}");
        }
        LogUtils.EmptyLine();
    }
}
