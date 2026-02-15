
public static class ConsoleUtils
{
    public static void WriteHeader(string header)
    {
        Console.WriteLine();
        HeaderSeparator(header.Length);
        Console.WriteLine($"## {header} ##");
        HeaderSeparator(header.Length);
        Console.WriteLine();
    }

    private static void HeaderSeparator(int length)
    {
        Console.WriteLine($"###{new string('#', length)}###");
    }

    public static void WriteSeparator(int length = 20)
    {
        Console.WriteLine(new string('-', length));
    }

    public static void WriteFooter(int length = 20)
    {
        Console.WriteLine(new string('=', length));
    }
}