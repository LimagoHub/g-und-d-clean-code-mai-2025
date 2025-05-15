namespace gi_und_de.container;

public abstract class AbstractArrayFactory<T>: IArrayFactory<T>
{
protected T[] Data { get; private set; }

protected abstract void FillData() ;
public  T[] CreateAndFillArray(in int size)
{
    Data = new T[size];
    FillData();
    return Data;
}
    
}