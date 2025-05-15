namespace LoggerDemo;

public class Logger
{
    
    private readonly IAppender _appender;

    internal Logger(IAppender appender)
    {
        _appender = appender;
    }

    public void log(string message)
    {
        string KOMPLIZIRTER_PREFIX = "PREFIX: ";
        _appender.write(KOMPLIZIRTER_PREFIX + message);
    }

    public static Logger create()
    {
        IAppender appender = new ConsoleAppender();
        return new Logger(appender);
    }
}