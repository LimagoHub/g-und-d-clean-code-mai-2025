namespace gi_und_de.container;

public interface IArrayFactory<T>
{
    T[] CreateAndFillArray(int size);
}