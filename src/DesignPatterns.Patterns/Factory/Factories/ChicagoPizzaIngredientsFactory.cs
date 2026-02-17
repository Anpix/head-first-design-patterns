using DesignPatterns.Patterns.Factory.Ingredients.Cheeses;
using DesignPatterns.Patterns.Factory.Ingredients.Clams;
using DesignPatterns.Patterns.Factory.Ingredients.Doughs;
using DesignPatterns.Patterns.Factory.Ingredients.Meats;
using DesignPatterns.Patterns.Factory.Ingredients.Sauces;
using DesignPatterns.Patterns.Factory.Ingredients.Veggies;

namespace DesignPatterns.Patterns.Factory.Factories;

public class ChicagoPizzaIngredientsFactory : IPizzaIngredientsFactory
{
    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Clam CreateClam()
    {
        return new FrozenClams();
    }

    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Meat CreateMeat()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public IList<Veggie> CreateVeggies()
    {
        return [new BlackOlives(), new Spinach(), new Eggplant()];
    }
}
