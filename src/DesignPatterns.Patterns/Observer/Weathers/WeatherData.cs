using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Weathers;

public class WeatherData : Subject
{
    public float GetTemperature()
    {
        return Random.Shared.Next(-10, 40);
    }

    public float GetHumidity()
    {
        return Random.Shared.Next(0, 100);
    }

    public float GetPressure()
    {
        return Random.Shared.Next(950, 1050);
    }

    public void MeasurementsChanged()
    {
        Temperature = GetTemperature();
        Humidity = GetHumidity();
        Pressure = GetPressure();

        NotifyObservers();
    }
}
