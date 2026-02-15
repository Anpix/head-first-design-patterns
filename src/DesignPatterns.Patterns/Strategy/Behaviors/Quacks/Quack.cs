namespace DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("I'm quacking!");
    }
}
