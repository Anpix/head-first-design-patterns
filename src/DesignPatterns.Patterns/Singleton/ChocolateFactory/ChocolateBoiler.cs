using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Singleton.ChocolateFactory;

public class ChocolateBoiler
{
    public bool IsEmpty { get; private set; }
    public bool IsBoiled { get; private set; }

    private static ChocolateBoiler? _instance;

    private ChocolateBoiler()
    {
        IsEmpty = true;
        IsBoiled = false;
    }

    public static ChocolateBoiler GetInstance() => _instance ??= new();

    public void Fill()
    {
        if (!IsEmpty)
        {
            LogUtils.Error("Boiler is already filled.");
            return;
        }

        IsEmpty = false;
        LogUtils.Info("Boiler is now filled.");
    }

    public void Boil()
    {
        if (IsEmpty)
        {
            LogUtils.Error("Cannot boil an empty boiler.");
            return;
        }

        if (IsBoiled)
        {
            LogUtils.Error("Cannot boil a boiler that is already boiled.");
            return;
        }

        IsBoiled = true;
        LogUtils.Info("Boiler is now boiled.");
    }

    public void Drain()
    {
        if (IsEmpty)
        {
            LogUtils.Error("Cannot drain an empty boiler.");
            return;
        }

        if (!IsBoiled)
        {
            LogUtils.Warning("This boiler is being drained without being boiled...");
        }

        IsEmpty = true;
        IsBoiled = false;
        LogUtils.Info("Boiler is now drained.");
    }
}
