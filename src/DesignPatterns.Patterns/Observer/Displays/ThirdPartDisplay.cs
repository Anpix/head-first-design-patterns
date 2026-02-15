using DesignPatterns.Patterns.Observer.Core.Displays;
using DesignPatterns.Patterns.Observer.Core.Subjects;
using DesignPatterns.Patterns.Utils;

namespace DesignPatterns.Patterns.Observer.Displays;

public class ThirdPartDisplay : Display
{
    public ThirdPartDisplay(ISubject subject) : base("Third Part Display", subject)
    {
    }

    public override void DisplayValues()
    {
        LogUtils.Warning($">> {Name} - Displaying differently! Just Temperature: {Temperature}°C");
    }
}
