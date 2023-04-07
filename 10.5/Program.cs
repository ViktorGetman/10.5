using _10._5;

class Program
{
    static ILogger Logger { get; set; }
    static void Main()
    {
        Logger = new Logger();

        var calculator = new Calculator(Logger);

        calculator.Calc();


        Console.ReadKey();
    }
}
public interface ILogger
{
    void Event(string message);
    void Eror(string message);
}

public class Logger : ILogger
{
    void ILogger.Eror(string message)
    {
        ConsoleColor mainColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = mainColor;
    }

    void ILogger.Event(string message)
    {
        ConsoleColor mainColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = mainColor;
    }
}

public interface IСalculator

{
    void Calc();
}