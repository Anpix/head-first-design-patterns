using DesignPatterns.Patterns.Factory.Ingredients.Cheeses;
using DesignPatterns.Patterns.Factory.Ingredients.Clams;
using DesignPatterns.Patterns.Factory.Ingredients.Doughs;
using DesignPatterns.Patterns.Factory.Ingredients.Meats;
using DesignPatterns.Patterns.Factory.Ingredients.Sauces;
using DesignPatterns.Patterns.Factory.Ingredients.Veggies;

namespace DesignPatterns.Patterns.Factory.Factories;

public class NYPizzaIngredientsFactory : IPizzaIngredientsFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clam CreateClam()
    {
        return new FreshClams();
    }

    public IList<Meat> CreateMeats()
    {
        return [new SlicedPepperoni()];
    }

    public IList<Veggie> CreateVeggies()
    {
        return [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
    }
}
