using DesignPatterns.Patterns.Observer.Displays;

namespace DesignPatterns.Patterns.Observer.Weathers;

public class WeatherData
{
    public CurrentConditionsDisplay? CurrentConditionsDisplay { get; set; }
    public StatisticsDisplay? StatisticsDisplay { get; set; }
    public ForecastDisplay? ForecastDisplay { get; set; }
    public ThirdPartDisplay? ThirdPartDisplay { get; set; }

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
        var temperature = GetTemperature();
        var humidity = GetHumidity();
        var pressure = GetPressure();

        CurrentConditionsDisplay?.Update(temperature, humidity, pressure);
        StatisticsDisplay?.Update(temperature, humidity, pressure);
        ForecastDisplay?.Update(temperature, humidity, pressure);
        ThirdPartDisplay?.Update(temperature, humidity, pressure);
    }
}
