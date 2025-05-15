using gi_und_de.client;
using gi_und_de.client.inner;
using gi_und_de.container;
using gi_und_de.container.inner.builder;
using gi_und_de.generator;
using gi_und_de.time;

namespace gi_und_de.bootstrap;

public class Bootstrap
{
    public void StartApplication()
    {
        var availableProcessors = Environment.ProcessorCount;
        for (var threadCount = 0; threadCount <= availableProcessors +1; threadCount++)
        {
            Run(threadCount);
        }
    }

    private static void Run(in int threadCount)
    {
        Console.WriteLine($"Running with {threadCount} threads.");
        IGeneratorBuilder<int> generatorBuilder = new RandomGeneratorBuilder();
        //IGenerator<int> generator = new GenericGenerator(1, v=>v+2);

        ArrayFactoryBuilder<int>.ThreadCount = threadCount;
        ArrayFactoryBuilder<int>.Logger = true;
        IArrayFactory<int> factory = ArrayFactoryBuilder<int>.create(generatorBuilder);
       
        factory = new ArrayFactoryBenchmarkDecorator<int>(factory, new MyStopwatch());
        IClient client = new Client(factory);
        client.DoSomethingWithLargeArray();
    }
}