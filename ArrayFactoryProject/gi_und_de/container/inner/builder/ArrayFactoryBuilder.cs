using gi_und_de.generator;
using gi_und_de.time;

namespace gi_und_de.container.inner.builder;

public class ArrayFactoryBuilder<T>
{
    public static IStopwatch? Stopwatch { get; set; }
    public static bool Logger { get; set; }
    public static bool Secure { get; set; }
    public static int ThreadCount { get; set; } = 1;

    public static IArrayFactory<T> create(in IGeneratorBuilder<T> generatorBuilder)
    {
        IArrayFactory<T> factory ;
        switch (ThreadCount)
        {
            case 0:
                factory = new ArrayFactoryAuto<T>(generatorBuilder);
                break;
            case 1:
                factory = new ArrayFactorySequential<T>(generatorBuilder.create());
                break;
            default:
                factory = new ArrayFactoryParallel<T>(generatorBuilder, ThreadCount);
                break;
        }
        if(Logger)
            factory = new ArrayFactoryLogger<T>(factory);
        if(Secure)
            factory = new ArrayFactorySecure<T>(factory);
        if(Stopwatch != null)
            factory = new ArrayFactoryBenchmarkDecorator<T>(factory, Stopwatch);
        return factory;
    }
    
}