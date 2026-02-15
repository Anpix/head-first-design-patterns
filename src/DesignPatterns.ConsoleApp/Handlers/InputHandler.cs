using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.ConsoleApp.Handlers;

public static class InputHandler
{
    public static void ReadInput()
    {
        Console.WriteLine();
        Console.Write("Inform the option number: ");
        var input = Console.ReadLine();
        if (input == null) return;

        HandleInput(input);
    }

    public static void HandleInput(string input)
    {
        if (!Enum.TryParse(input, true, out CommandEnum command))
        {
            command = CommandEnum.UNKNOWN;
        }
        ExercisesHandler.HandleCommand(command);
    }
}
