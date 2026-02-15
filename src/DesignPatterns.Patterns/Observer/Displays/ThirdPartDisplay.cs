using DesignPatterns.Patterns.Observer.Core.Displays;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Displays;

public class ThirdPartDisplay : Display
{
    public ThirdPartDisplay() : base("Third Part Display")
    {
    }

    public override void DisplayValues()
    {
        LogUtils.Warning($">> {Name} - Displaying differently! Just Temperature: {Temperature}°C");
    }
}
