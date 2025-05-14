using gi_und_de.container;

namespace gi_und_de.client.inner;

public class Client: IClient
{

    private IArrayFactory<int> ArrayFactory { get;  }

    public Client(IArrayFactory<int> arrayFactory)
    {
        ArrayFactory = arrayFactory;
    }

    public void DoSomethingWithLargeArray()
    {
        var feld = ArrayFactory.CreateAndFillArray(1000);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(feld[i]);
        }
    }
}