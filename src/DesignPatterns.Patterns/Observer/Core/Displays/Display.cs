using DesignPatterns.Patterns.Observer.Displays;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Core.Displays;

public class Display : Observers.Observer, IDisplay
{
    public Display(string name) : base(name)
    {
    }

    public override void Update(float temperature, float humidity, float pressure)
    {
        base.Update(temperature, humidity, pressure);
        DisplayValues();
    }

    public virtual void DisplayValues()
    {
        LogUtils.Success($">> {Name} - Temperature: {Temperature}°C, Humidity: {Humidity}%, Pressure: {Pressure} hPa");
    }
}
