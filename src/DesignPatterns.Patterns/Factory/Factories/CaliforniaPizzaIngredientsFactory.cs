using DesignPatterns.Patterns.Factory.Ingredients.Cheeses;
using DesignPatterns.Patterns.Factory.Ingredients.Clams;
using DesignPatterns.Patterns.Factory.Ingredients.Doughs;
using DesignPatterns.Patterns.Factory.Ingredients.Meats;
using DesignPatterns.Patterns.Factory.Ingredients.Sauces;
using DesignPatterns.Patterns.Factory.Ingredients.Veggies;

namespace DesignPatterns.Patterns.Factory.Factories;

public class CaliforniaPizzaIngredientsFactory : IPizzaIngredientsFactory
{

    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }
    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clam CreateClam()
    {
        return new FreshClams();
    }

    public Meat CreateMeat()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public IList<Veggie> CreateVeggies()
    {
        return [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
    }
}
