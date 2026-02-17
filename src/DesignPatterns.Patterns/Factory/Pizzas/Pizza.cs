using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Ingredients.Cheeses;
using DesignPatterns.Patterns.Factory.Ingredients.Clams;
using DesignPatterns.Patterns.Factory.Ingredients.Doughs;
using DesignPatterns.Patterns.Factory.Ingredients.Meats;
using DesignPatterns.Patterns.Factory.Ingredients.Sauces;
using DesignPatterns.Patterns.Factory.Ingredients.Veggies;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public abstract class Pizza
{
    public IPizzaIngredientsFactory IngredientsFactory { get; init; }
    public abstract string Name { get; }
    public Dough Dough { get; set; }
    public Sauce Sauce { get; set; }
    public IList<Veggie> Veggies { get; set; }
    public Cheese Cheese { get; set; }
    public Meat Meat { get; set; }
    public Clam Clam { get; set; }

    public Pizza(IPizzaIngredientsFactory ingredientsFactory)
    {
        IngredientsFactory = ingredientsFactory;
        Dough = IngredientsFactory.CreateDough();
        Sauce = IngredientsFactory.CreateSauce();
        Cheese = IngredientsFactory.CreateCheese();
        Meat = IngredientsFactory.CreateMeat();
        Clam = IngredientsFactory.CreateClam();
        Veggies = IngredientsFactory.CreateVeggies();
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
        LogUtils.Warning($"Describing {Name}...");
        LogUtils.Info($"Dough: {Dough.Name}");
        LogUtils.Info($"Sauce: {Sauce.Name}");
        LogUtils.Info($"Cheese: {Cheese.Name}");
        LogUtils.Info($"Meat: {Meat.Name}");
        LogUtils.Info($"Clam: {Clam.Name}");
        LogUtils.Info("Veggies:");
        foreach (var veggie in Veggies)
        {
            LogUtils.Info($"- {veggie.Name}");
        }
        LogUtils.EmptyLine();
    }
}
