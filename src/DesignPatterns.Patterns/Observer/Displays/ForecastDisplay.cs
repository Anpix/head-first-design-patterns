using DesignPatterns.Patterns.Observer.Core.Displays;
using DesignPatterns.Patterns.Observer.Core.Subjects;

namespace DesignPatterns.Patterns.Observer.Displays;

public class ForecastDisplay : Display
{
    public ForecastDisplay(ISubject subject) : base("Forecast Display", subject)
    {
    }
}
