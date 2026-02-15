using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Core.Observers;

public abstract class Observer : IObserver
{
    protected readonly string Name;

    protected Observer(string name)
    {
        Name = name;
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        LogUtils.Info($">> {Name} - Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure} hPa");

    }
}
