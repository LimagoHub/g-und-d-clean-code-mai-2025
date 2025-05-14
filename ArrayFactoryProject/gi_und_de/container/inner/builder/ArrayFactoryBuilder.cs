using gi_und_de.generator;
using gi_und_de.time;

namespace gi_und_de.container.inner.builder;

public class ArrayFactoryBuilder<T>
{
    public static IStopwatch? Stopwatch { get; set; }
    public static bool Logger { get; set; }
    public static bool Secure { get; set; }


    public static IArrayFactory<T> create(IGenerator<T> generator)
    {
        IArrayFactory<T> factory = new ArrayFactorySequential<T>(generator);
        if(Logger)
            factory = new ArrayFactoryLogger<T>(factory);
        if(Secure)
            factory = new ArrayFactorySecure<T>(factory);
        if(Stopwatch != null)
            factory = new ArrayFactoryBenchmarkDecorator<T>(factory, Stopwatch);
        return factory;
    }
    
}