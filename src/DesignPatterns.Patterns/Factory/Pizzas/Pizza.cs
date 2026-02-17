using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public abstract class Pizza
{
    public abstract string Name { get; init; }
    public abstract string Dough { get; init; }
    public abstract string Sauce { get; init; }
    public abstract IList<string> Toppings { get; init; }

    public virtual void Prepare()
    {
        LogUtils.Info($"Preparing {Name}...");
        LogUtils.Info($"- Tossing dough: {Dough}");
        LogUtils.Info($"- Adding sauce: {Sauce}");
        LogUtils.Info($"- Adding toppings: {string.Join(", ", Toppings)}");
        LogUtils.EmptyLine();
    }

    public virtual void Bake()
    {
        LogUtils.Info($"Bake {Name} for 25 minutes at 350ºC...");
    }

    public virtual void Cut()
    {
        LogUtils.Info($"Cut {Name} into diagonal slices...");
    }

    public virtual void Box()
    {
        LogUtils.Info($"Place {Name} in official PizzaStore box...");
    }
}
