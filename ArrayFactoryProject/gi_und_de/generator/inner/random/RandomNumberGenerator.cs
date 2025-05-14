namespace gi_und_de.generator;

public class RandomNumberGenerator: IGenerator<int>
{
        private readonly Random _random = Random.Shared;
        public virtual int Next()
        {
            return _random.Next();
            
        }

}