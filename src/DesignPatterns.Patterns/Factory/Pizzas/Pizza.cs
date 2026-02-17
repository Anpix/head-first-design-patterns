using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public abstract class Pizza
{
    public string Name => this.GetType().Name;

    public void Prepare()
    {
        LogUtils.Info("Preparing...");
    }

    public void Bake()
    {
        LogUtils.Info("Baking...");
    }

    public void Cut()
    {
        LogUtils.Info("Cutting...");
    }

    public void Box()
    {
        LogUtils.Info("Boxing...");
    }
}
