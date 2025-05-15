using gi_und_de.container;

namespace gi_und_de.client.inner;

public class Client: IClient
{

    private IArrayFactory<int> ArrayFactory { get;  }

    public Client(in IArrayFactory<int> arrayFactory)
    {
        ArrayFactory = arrayFactory;
    }

    public void DoSomethingWithLargeArray()
    {
        var feld = ArrayFactory.CreateAndFillArray(Int32.MaxValue/4);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(feld[i]);
        }
    }
}