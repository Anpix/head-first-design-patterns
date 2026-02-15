using DesignPatterns.Patterns.Observer.Core.Displays;
using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Displays;

public class StatisticsDisplay : Display
{
    public StatisticsDisplay(ISubject subject) : base("Statistics Display", subject)
    {
    }
}
