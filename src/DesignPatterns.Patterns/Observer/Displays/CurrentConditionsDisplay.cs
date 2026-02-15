using DesignPatterns.Patterns.Observer.Core.Observers;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Displays;

public class CurrentConditionsDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        LogUtils.Info($"Current Conditions Display - Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure} hPa");
    }
}
