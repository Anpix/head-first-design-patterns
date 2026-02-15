using DesignPatterns.Patterns.Observer.Core.Observers;

namespace DesignPatterns.Patterns.Observer.Core.Subjects;

public abstract class Subjectable : ISubject
{
    protected IList<IObserver> Observers { get; set; } = [];

    protected float Temperature { get; set; }
    protected float Humidity { get; set; }
    protected float Pressure { get; set; }

    protected bool Changed { get; private set; }

    public void RegisterObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;

        MeasurementsChanged();
    }

    public void MeasurementsChanged()
    {
        Changed = true;
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        if (!Changed)
            return;

        foreach (var observer in Observers)
            observer.Update(Temperature, Humidity, Pressure);

        Changed = false;
    }
}
