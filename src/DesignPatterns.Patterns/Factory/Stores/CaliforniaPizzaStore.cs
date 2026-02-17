using DesignPatterns.Patterns.Factory.Factories;

namespace DesignPatterns.Patterns.Factory.Stores;

public class CaliforniaPizzaStore : PizzaStore
{
    public override string Name => "California Pizza Store";

    public CaliforniaPizzaStore(IPizzaIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
    {
    }
}
