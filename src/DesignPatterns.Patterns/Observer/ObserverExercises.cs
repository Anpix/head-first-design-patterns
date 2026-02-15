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
        Page37();
    }

    public static void Page37()
    {
        LogUtils.SubHeader("Page 37");

        var weatherData = new WeatherData();
        weatherData.RegisterObserver(new CurrentConditionsDisplay());
        weatherData.RegisterObserver(new StatisticsDisplay());
        weatherData.RegisterObserver(new ForecastDisplay());
        weatherData.RegisterObserver(new ThirdPartDisplay());

        LogUtils.Info("Simulating weather data changes...");
        for (int i = 0; i < 5; i++)
        {
            ConsoleUtils.WriteSeparator();
            weatherData.MeasurementsChanged();
            Thread.Sleep(200);
        }

        LogUtils.Footer();
    }
}