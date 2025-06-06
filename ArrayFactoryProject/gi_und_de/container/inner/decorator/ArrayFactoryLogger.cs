﻿using System.Security.Principal;

namespace gi_und_de.container;

public class ArrayFactoryLogger<T>: IArrayFactory<T>
{
    private IArrayFactory<T> ArrayFactory {
        get;
       
    }

    public ArrayFactoryLogger(in IArrayFactory<T> arrayFactory)
    {
        ArrayFactory = arrayFactory;
    }

    public T[] CreateAndFillArray(in int size)
    {
        Console.WriteLine("Creating array");
        return ArrayFactory.CreateAndFillArray(size);
    }
}