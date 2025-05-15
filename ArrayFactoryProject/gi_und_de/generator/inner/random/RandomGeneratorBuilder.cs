namespace gi_und_de.generator;

public class RandomGeneratorBuilder: IGeneratorBuilder<int>
{
    public IGenerator<int> create()
    {
        return new RandomNumberGenerator();
    }
}
