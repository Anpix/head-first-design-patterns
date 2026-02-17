using DesignPatterns.Patterns.Factory.Factories;

namespace DesignPatterns.Patterns.Factory.Stores;

public class NYPizzaStore : PizzaStore
{
    public override string Name => "NY Pizza Store";

    public NYPizzaStore(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }
}
