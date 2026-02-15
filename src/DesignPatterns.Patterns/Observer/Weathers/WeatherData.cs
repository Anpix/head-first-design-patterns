using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Weathers;

public class WeatherData : Subject
{
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;

        MeasurementsChanged();
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

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
}
