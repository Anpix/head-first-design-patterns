using DesignPatterns.Patterns.Factory.Ingredients.Cheeses;
using DesignPatterns.Patterns.Factory.Ingredients.Doughs;
using DesignPatterns.Patterns.Factory.Ingredients.Sauces;
using DesignPatterns.Patterns.Factory.Ingredients.Veggies;
using DesignPatterns.Patterns.Factory.Ingredients.Meats;
using DesignPatterns.Patterns.Factory.Ingredients.Clams;

namespace DesignPatterns.Patterns.Factory.Factories;

public interface IPizzaIngredientsFactory
{
    public abstract Dough CreateDough();
    public abstract Sauce CreateSauce();
    public abstract Meat CreateMeat();
    public abstract IList<Veggie> CreateVeggies();
    public abstract Cheese CreateCheese();
    public abstract Clam CreateClam();
}
