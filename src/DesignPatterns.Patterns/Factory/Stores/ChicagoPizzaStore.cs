using DesignPatterns.Patterns.Factory.Factories;

namespace DesignPatterns.Patterns.Factory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    public override string Name => "Chicago Pizza Store";

    public ChicagoPizzaStore(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }
}
