using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Weathers;

public class WeatherData : Subjectable
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
}
