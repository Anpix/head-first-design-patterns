using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Core.Observers;

public abstract class Observable : IObserver
{
    protected ISubject Subject;
    protected readonly string Name;

    protected float Temperature;
    protected float Humidity;
    protected float Pressure;

    protected Observable(string name, ISubject subject)
    {
        Name = name;
        Subject = subject;
        Subscribe();
    }

    public virtual void Update(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }

    public virtual void Subscribe(ISubject? subject = null)
    {
        if (subject != null)
            Subject = subject;

        Subject.RegisterObserver(this);
    }

    public virtual void Unsubscribe()
    {
        Subject.RemoveObserver(this);
    }
}
