using System.Xml.XPath;
using gi_und_de.time;

namespace gi_und_de.container;

public class ArrayFactoryBenchmarkDecorator<T>: IArrayFactory<T>
{
    private IArrayFactory<T> ArrayFactory { get; }
    private IStopwatch Stopwatch { get; }

    public ArrayFactoryBenchmarkDecorator(IArrayFactory<T> arrayFactory, IStopwatch stopwatch)
    {
        ArrayFactory = arrayFactory;
        Stopwatch = stopwatch;
    }

    public T[] CreateAndFillArray(int size)
    {
        Stopwatch.Start();
        var result =  ArrayFactory.CreateAndFillArray(size);
        Stopwatch.Stop();
        var duration = Stopwatch.Elapsed;
        Console.WriteLine($"Duration = {duration} ms");
        return result;
    }
}