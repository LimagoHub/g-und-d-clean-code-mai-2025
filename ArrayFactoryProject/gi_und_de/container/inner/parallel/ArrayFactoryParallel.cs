using gi_und_de.generator;

namespace gi_und_de.container;

public class ArrayFactoryParallel<T> : AbstractArrayFactory<T>
{
    private readonly IGeneratorBuilder <T> _generatorBuilder;
    private readonly int _numberOfThreads;
    private readonly IList<Task> _threadHolder ;
    private int _partitionSize;
    public ArrayFactoryParallel(in IGeneratorBuilder<T> generatorBuilder,in int numberOfThreads)
    {
        
        _generatorBuilder = generatorBuilder;
        _numberOfThreads = numberOfThreads;
        _threadHolder = new List<Task>(_numberOfThreads);
    }

    protected sealed override void FillData()
    {
        CalculateSegmentSize();
        AddSegmentFillWorkerToThreadPool();
        AwaitTermination();
    }

    
    private void AddSegmentFillWorkerToThreadPool()
    {
        for (int currentThreadNumber = 0; currentThreadNumber < _numberOfThreads; currentThreadNumber++)
        {
            StartSingleWorker(currentThreadNumber);
        }
    }
 

    private void StartSingleWorker(in int currentThreadNumber)
    {
        var segmentBorders = calculateCurrentSegmentBorders(currentThreadNumber);
        _threadHolder.Add(Task.Run(()=>this.FillSegmentWorker(segmentBorders)));
    }
    
    private void AwaitTermination() => Task.WaitAll(_threadHolder.ToArray());
    private void CalculateSegmentSize() => _partitionSize = (Data.Length / _numberOfThreads);

    private (int Start, int End) calculateCurrentSegmentBorders(in int currentThreadNumber)
    {
        int start = _partitionSize * currentThreadNumber;
        int end = start + _partitionSize;
        return (start, end);
    }

    private void FillSegmentWorker(in (int Start, int End) segmentBorders)
    {
        //Console.WriteLine($"Start: {start} End: {end}");

        var generator = _generatorBuilder.create();
        for (int i = segmentBorders.Start; i < segmentBorders.End; i++)
        {
            Data[i] = generator.Next();
        }
    }
}