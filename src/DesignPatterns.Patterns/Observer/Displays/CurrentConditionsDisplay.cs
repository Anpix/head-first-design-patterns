using DesignPatterns.Patterns.Observer.Core.Displays;
using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Displays;

public class CurrentConditionsDisplay : Displayable
{
    public CurrentConditionsDisplay(ISubject subject) : base("Current Conditions Display", subject)
    {
    }
}
