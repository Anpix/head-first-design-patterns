using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Factory.Pizzas;

public class Pizza
{



    public void Prepare()
    {
        LogUtils.Info("Preparing pizza...");
    }

    public void Bake()
    {
        LogUtils.Info("Baking pizza...");
    }

    public void Cut()
    {
        LogUtils.Info("Cutting pizza...");
    }

    public void Box()
    {
        LogUtils.Info("Boxing pizza...");
    }
}
