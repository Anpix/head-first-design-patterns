using DesignPatterns.Patterns.Observer.Core.Observers;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Displays;

public class ForecastDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        LogUtils.Info($"Forecast Display - Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure} hPa");
    }
}
