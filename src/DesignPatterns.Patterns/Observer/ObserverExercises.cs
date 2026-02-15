using DesignPatterns.Patterns.Core;
using DesignPatterns.Patterns.Observer.Displays;
using DesignPatterns.Patterns.Observer.Weathers;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer;

public class ObserverExercises : Exercise
{
    public override void Run()
    {
        LogUtils.Header("Observer Exercises");
        Page41();
    }

    public static void Page41()
    {
        LogUtils.SubHeader("Page 41");

        var currentConditionsDisplay = new CurrentConditionsDisplay();
        var statisticsDisplay = new StatisticsDisplay();
        var forecastDisplay = new ForecastDisplay();
        var thirdPartDisplay = new ThirdPartDisplay();

        LogUtils.Info("Creating weather data...");
        var weatherData = new WeatherData();
        LogUtils.Info("Registering observers...");
        weatherData.RegisterObserver(currentConditionsDisplay);
        weatherData.RegisterObserver(statisticsDisplay);
        weatherData.RegisterObserver(forecastDisplay);
        weatherData.RegisterObserver(thirdPartDisplay);

        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        ConsoleUtils.WriteSeparator();

        LogUtils.Info("Removing ThirdPartDisplay and StatisticsDisplay observers...");
        weatherData.RemoveObserver(thirdPartDisplay);
        weatherData.RemoveObserver(statisticsDisplay);
        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        ConsoleUtils.WriteSeparator();

        LogUtils.Info("Adding back StatisticsDisplay observer...");
        weatherData.RegisterObserver(statisticsDisplay);
        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        ConsoleUtils.WriteSeparator();

        LogUtils.Footer();
    }
}