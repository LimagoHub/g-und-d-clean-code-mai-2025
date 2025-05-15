namespace gi_und_de.container;

public class ArrayFactorySecure<T>:IArrayFactory<T>
{
    private IArrayFactory<T> ArrayFactory {
        get;
       
    }

    public ArrayFactorySecure(in IArrayFactory<T> arrayFactory)
    {
        ArrayFactory = arrayFactory;
    }

    public T[] CreateAndFillArray(in int size)
    {
        
        Console.WriteLine("Du kommst hier rein");
        return ArrayFactory.CreateAndFillArray(size);
    }
}