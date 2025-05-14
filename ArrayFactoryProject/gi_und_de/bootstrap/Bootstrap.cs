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
        Console.WriteLine($"Running with 1 threads.");
        IGenerator<int> generator = new RandomNumberGenerator();
        //IGenerator<int> generator = new GenericGenerator(1, v=>v+2);

        ArrayFactoryBuilder<int>.Logger = true;
        IArrayFactory<int> factory = ArrayFactoryBuilder<int>.create(generator);
       
        factory = new ArrayFactoryBenchmarkDecorator<int>(factory, new MyStopwatch());
        IClient client = new Client(factory);
        client.DoSomethingWithLargeArray();
    }
}