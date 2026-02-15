using DesignPatterns.ConsoleApp.Enums;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.ConsoleApp.Handlers;

public static class InputHandler
{
    public static void ReadInput()
    {
        ConsoleUtils.Clear();
        ConsoleUtils.WriteInfo("Inform the option number: ");
        var input = ConsoleUtils.ReadInput();
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
