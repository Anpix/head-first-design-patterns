namespace DesignPatterns.Patterns.Observer.Weathers;

public static class WeatherUtils
{
    public static WeatherData GenerateWeatherData(this WeatherData weatherData)
    {
        weatherData.SetMeasurements(GenerateTemperature(), GenerateHumidity(), GeneratePressure());
        return weatherData;
    }

    public static float GenerateTemperature()
    {
        return Random.Shared.Next(-10, 40);
    }

    public static float GenerateHumidity()
    {
        return Random.Shared.Next(0, 100);
    }

    public static float GeneratePressure()
    {
        return Random.Shared.Next(950, 1050);
    }
}
