namespace DesignPatterns.Patterns.Observer.Core.Observers;

public abstract class Observer : IObserver
{
    protected readonly string Name;

    protected float Temperature;
    protected float Humidity;
    protected float Pressure;

    protected Observer(string name)
    {
        Name = name;
    }

    public virtual void Update(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }
}
