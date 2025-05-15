namespace LoggerDemo;

public class ConsoleAppender: IAppender
{
    public void write(string message)
    {
        Console.WriteLine(message);
    }
}