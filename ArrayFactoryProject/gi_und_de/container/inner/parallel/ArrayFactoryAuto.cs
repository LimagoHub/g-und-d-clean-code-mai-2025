using gi_und_de.generator;

namespace gi_und_de.container;

public class ArrayFactoryAuto<T> : AbstractArrayFactory<T>
{
    
    private readonly IGeneratorBuilder<T> _generatorBuilder;

    public ArrayFactoryAuto(in IGeneratorBuilder<T> generatorBuilder)
    {
        
        
        this._generatorBuilder = generatorBuilder;
    }
    protected sealed override void FillData()
    {
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = 4
        };
        
        Parallel.For(0, Data.Length,options, i =>
        {
            var generator = _generatorBuilder.create();// Thread Local
            Data[i] = generator.Next();
        });
       
    }
}