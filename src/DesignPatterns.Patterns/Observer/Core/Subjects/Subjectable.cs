using DesignPatterns.Patterns.Observer.Core.Observers;

namespace DesignPatterns.Patterns.Observer.Core.Subjects;

public abstract class Subjectable : ISubject
{
    protected IList<IObserver> Observers { get; set; } = [];

    protected float Temperature { get; set; }
    protected float Humidity { get; set; }
    protected float Pressure { get; set; }

    public void RegisterObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers)
            observer.Update(Temperature, Humidity, Pressure);
    }
}
