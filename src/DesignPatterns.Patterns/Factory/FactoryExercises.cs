using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Store;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory;

public class FactoryExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Factory Exercises");
        Page86();
    }

    private static void Page86()
    {
        LogUtils.SubHeader(nameof(Page86));

        var nyFactory = new NYPizzaFactory();
        var chicagoFactory = new ChicagoPizzaFactory();
        var pizzaStore = new PizzaStore(nyFactory);
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
