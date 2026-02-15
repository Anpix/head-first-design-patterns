namespace DesignPatterns.Patterns.Strategy.Animals;

public class Dog : Animal
{
    public override void MakeSound()
    {
        Bark();
    }

    public static void Bark()
    {
        Console.WriteLine("Woof");
    }
}
