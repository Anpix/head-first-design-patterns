using DesignPatterns.Patterns.Observer.Core.Observers;

namespace DesignPatterns.Patterns.Observer.Core.Subjects;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
