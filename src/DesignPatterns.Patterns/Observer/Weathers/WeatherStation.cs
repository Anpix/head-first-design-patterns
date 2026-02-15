using DesignPatterns.Patterns.Observer.Displays;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Weathers;

public static class WeatherStation
{
    public static void Run()
    {
        LogUtils.Warning("Creating weather data...");
        var weatherData = new WeatherData();

        LogUtils.Warning("Creating displays...");
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        var statisticsDisplay = new StatisticsDisplay(weatherData);
        var forecastDisplay = new ForecastDisplay(weatherData);

        LogUtils.Warning("Simulating 1st weather data change...");
        weatherData.GenerateWeatherData();
        LogUtils.Warning("Simulating 2nd weather data change...");
        weatherData.GenerateWeatherData();
        LogUtils.Warning("Simulating 3rd weather data change...");
        weatherData.GenerateWeatherData();
    }
}
