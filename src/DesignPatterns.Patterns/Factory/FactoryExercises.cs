using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Factory.Store;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory;

public class FactoryExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Factory Exercises");
        Page84();
    }

    private static void Page84()
    {
        LogUtils.SubHeader(nameof(Page84));

        var factory = new SimplePizzaFactory();
        var pizzaStore = new PizzaStore(factory);
        LogUtils.EmptyLine();

        LogUtils.Warning("Ordering pizzas...");
        ConsoleUtils.WriteSeparator();
        pizzaStore.Order("cheese");
        ConsoleUtils.WriteSeparator();
        pizzaStore.Order("greek");
        ConsoleUtils.WriteSeparator();
        pizzaStore.Order("pepperoni");
        ConsoleUtils.WriteSeparator();
        pizzaStore.Order("clam");
        ConsoleUtils.WriteSeparator();
        pizzaStore.Order("veggie");

        LogUtils.Footer();
    }
}
