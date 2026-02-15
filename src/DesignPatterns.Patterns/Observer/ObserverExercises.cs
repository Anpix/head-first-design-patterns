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
        Page42();
        Page48();
    }

    public static void Page42()
    {
        LogUtils.SubHeader("Page 42");


        LogUtils.Info("Creating weather data...");
        var weatherData = new WeatherData();

        LogUtils.Info("Creating displays...");
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        var statisticsDisplay = new StatisticsDisplay(weatherData);
        var forecastDisplay = new ForecastDisplay(weatherData);
        var thirdPartDisplay = new ThirdPartDisplay(weatherData);

        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        ConsoleUtils.WriteSeparator();

        LogUtils.Warning("Removing ThirdPartDisplay and StatisticsDisplay observers...");
        thirdPartDisplay.Unsubscribe();
        statisticsDisplay.Unsubscribe();
        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        ConsoleUtils.WriteSeparator();

        LogUtils.Warning("Adding back StatisticsDisplay observer...");
        statisticsDisplay.Subscribe();
        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        ConsoleUtils.WriteSeparator();

        LogUtils.Warning("Removing All observers...");
        currentConditionsDisplay.Unsubscribe();
        statisticsDisplay.Unsubscribe();
        forecastDisplay.Unsubscribe();
        thirdPartDisplay.Unsubscribe();
        LogUtils.Info("Simulating weather data changes...");
        weatherData.MeasurementsChanged();
        LogUtils.Success("Should not receive any updates");

        LogUtils.Footer();
    }

    public static void Page48()
    {
        LogUtils.SubHeader("Page 48");
        WeatherStation.Run();
        LogUtils.Footer();
    }
}