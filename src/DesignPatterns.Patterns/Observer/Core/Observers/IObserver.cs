namespace DesignPatterns.Patterns.Observer.Core.Observers;

public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}
