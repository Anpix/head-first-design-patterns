namespace DesignPatterns.Patterns.Strategy.Behaviors.Fly;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly!");
    }
}
