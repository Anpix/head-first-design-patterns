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
        Page31();
    }

    public static void Page31()
    {
        LogUtils.SubHeader("Page 31");

        var weatherData = new WeatherData
        {
            CurrentConditionsDisplay = new CurrentConditionsDisplay(),
            StatisticsDisplay = new StatisticsDisplay(),
            ForecastDisplay = new ForecastDisplay(),
            ThirdPartDisplay = new ThirdPartDisplay()
        };

        LogUtils.Info("Simulating weather data changes...");
        for (int i = 0; i < 5; i++)
        {
            ConsoleUtils.WriteSeparator();
            weatherData.MeasurementsChanged();
            System.Threading.Thread.Sleep(200);
        }

        LogUtils.Footer();
    }
}