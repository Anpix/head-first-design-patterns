namespace DesignPatterns.Patterns.Strategy.Animals;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Meow();
    }

    public static void Meow()
    {
        Console.WriteLine("Meow");
    }
}
