namespace DesignPatterns.Patterns.Strategy.Behaviors.Quacks;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("I can't quack!");
    }
}
