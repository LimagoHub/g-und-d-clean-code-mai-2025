namespace gi_und_de.generator;

public interface IGeneratorBuilder<T>
{
    IGenerator<T> create();
}