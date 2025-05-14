using gi_und_de.generator;

namespace gi_und_de.container;

public class ArrayFactorySequential<T>: AbstractArrayFactory<T>
{
    private readonly IGenerator<T> _generator;

    public ArrayFactorySequential(IGenerator<T> generator)
    {
        this._generator = generator;
    }

    protected sealed override void FillData()
    {
        for (var i = 0; i < Data.Length; i++)
        {
            Data[i] = _generator.Next();
        }
    }
}