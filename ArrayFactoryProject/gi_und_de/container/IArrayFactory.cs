namespace gi_und_de.container;

public interface IArrayFactory<T>
{
    T[] CreateAndFillArray(in int size);
}