namespace DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("I'm squeaking!");
    }
}
