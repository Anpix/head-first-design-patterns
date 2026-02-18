using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Factory.Factories;
using DesignPatterns.Patterns.Factory.Stores;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory;

public class FactoryExercises : IExercise
{
    public static void Run()
    {
        LogUtils.Header("Factory Exercises");
        Page110();
    }

    private static void Page110()
    {
        var nyFactory = new NYPizzaIngredientsFactory();
        var chicagoFactory = new ChicagoPizzaIngredientsFactory();
        var californiaFactory = new CaliforniaPizzaIngredientsFactory();

        var nyStore = new NYPizzaStore(nyFactory);
        var chicagoStore = new ChicagoPizzaStore(chicagoFactory);
        var californiaStore = new CaliforniaPizzaStore(californiaFactory);

        LogUtils.EmptyLine();

        LogUtils.SubHeader("Ordering pizzas in NY");
        nyStore.Order("cheese");
        LogUtils.EmptyLine();
        nyStore.Order("greek");
        LogUtils.EmptyLine();
        nyStore.Order("pepperoni");
        LogUtils.EmptyLine();
        nyStore.Order("clam");
        LogUtils.EmptyLine();
        nyStore.Order("veggie");

        LogUtils.Footer();

        LogUtils.SubHeader("Ordering pizzas in Chicago");
        chicagoStore.Order("cheese");
        LogUtils.EmptyLine();
        chicagoStore.Order("greek");
        LogUtils.EmptyLine();
        chicagoStore.Order("pepperoni");
        LogUtils.EmptyLine();
        chicagoStore.Order("clam");
        LogUtils.EmptyLine();
        chicagoStore.Order("veggie");

        LogUtils.Footer();

        LogUtils.SubHeader("Ordering pizzas in California");
        californiaStore.Order("cheese");
        LogUtils.EmptyLine();
        californiaStore.Order("greek");
        LogUtils.EmptyLine();
        californiaStore.Order("pepperoni");
        LogUtils.EmptyLine();
        californiaStore.Order("clam");
        LogUtils.EmptyLine();
        californiaStore.Order("veggie");

        LogUtils.Footer();
    }
}
