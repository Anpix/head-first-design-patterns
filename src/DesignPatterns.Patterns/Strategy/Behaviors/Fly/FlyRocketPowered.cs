namespace DesignPatterns.Patterns.Strategy.Behaviors.Fly;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
