using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Factory.Stores;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory;

public class FactoryExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Factory Exercises");
        Page92();
    }

    private static void Page92()
    {
        LogUtils.SubHeader(nameof(Page92));

        var nyStore = new NYPizzaStore();
        LogUtils.EmptyLine();

        LogUtils.Warning("Ordering pizzas...");
        ConsoleUtils.WriteSeparator();
        nyStore.Order("cheese");
        ConsoleUtils.WriteSeparator();
        nyStore.Order("greek");
        ConsoleUtils.WriteSeparator();
        nyStore.Order("pepperoni");
        ConsoleUtils.WriteSeparator();
        nyStore.Order("clam");
        ConsoleUtils.WriteSeparator();
        nyStore.Order("veggie");


        var chicagoStore = new ChicagoPizzaStore();
        LogUtils.EmptyLine();

        LogUtils.Warning("Ordering pizzas...");
        ConsoleUtils.WriteSeparator();
        chicagoStore.Order("cheese");
        ConsoleUtils.WriteSeparator();
        chicagoStore.Order("greek");
        ConsoleUtils.WriteSeparator();
        chicagoStore.Order("pepperoni");
        ConsoleUtils.WriteSeparator();
        chicagoStore.Order("clam");
        ConsoleUtils.WriteSeparator();
        chicagoStore.Order("veggie");

        var californiaStore = new CaliforniaPizzaStore();
        LogUtils.EmptyLine();

        LogUtils.Warning("Ordering pizzas...");
        ConsoleUtils.WriteSeparator();
        californiaStore.Order("cheese");
        ConsoleUtils.WriteSeparator();
        californiaStore.Order("greek");
        ConsoleUtils.WriteSeparator();
        californiaStore.Order("pepperoni");
        ConsoleUtils.WriteSeparator();
        californiaStore.Order("clam");
        ConsoleUtils.WriteSeparator();
        californiaStore.Order("veggie");

        LogUtils.Footer();
    }
}
