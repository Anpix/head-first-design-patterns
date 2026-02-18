using DesignPatterns.Patterns.Factory.Ingredients.Cheeses;
using DesignPatterns.Patterns.Factory.Ingredients.Clams;
using DesignPatterns.Patterns.Factory.Ingredients.Doughs;
using DesignPatterns.Patterns.Factory.Ingredients.Meats;
using DesignPatterns.Patterns.Factory.Ingredients.Sauces;
using DesignPatterns.Patterns.Factory.Ingredients.Veggies;

namespace DesignPatterns.Patterns.Factory.Factories;

public class ChicagoPizzaIngredientsFactory : IPizzaIngredientsFactory
{

    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Clam CreateClam()
    {
        return new FrozenClams();
    }

    public IList<Meat> CreateMeats()
    {
        return [new SlicedPepperoni()];
    }

    public IList<Veggie> CreateVeggies()
    {
        return [new BlackOlives(), new Spinach(), new Eggplant()];
    }
}
