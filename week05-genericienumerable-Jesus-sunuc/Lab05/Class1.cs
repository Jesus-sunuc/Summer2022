using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab05;

public class MyList<T> : IEnumerable<T>
{
    private T[] ArrayNumber { get; }

    public IEnumerator GetEnumerator()
    {
        MyListEnumerator<T> ObjectWithIEnumerator = new MyListEnumerator<T>(ArrayNumber);
        return ObjectWithIEnumerator;
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        MyListEnumerator<T> ObjectWithIEnumerator = new MyListEnumerator<T>(ArrayNumber);
        return ObjectWithIEnumerator;
    }

    public MyList(T[] arrayNumber)
    {
        ArrayNumber = arrayNumber;
    }
}

public class MyListEnumerator<T> : IEnumerator<T>
{
    private T[] Reference { get; }
    private int InternalIndex { get; set; } = -1;
    public T Current
    {
        get
        {
            try
            {
                return Reference[InternalIndex];
            }
            catch (System.IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    private object Current2
    {
        get { return Current; }
    }

    object IEnumerator.Current
    {
        get { return Current2; }
    }

    public bool MoveNext()
    {
        InternalIndex++;
        return (InternalIndex < Reference.Length);
    }

    public void Reset()
    {
        InternalIndex = -1;
    }

    public void Dispose()
    {
        InternalIndex = -1;
    }

    public MyListEnumerator(T[] incomingArray)
    {
        Reference = incomingArray;
    }
}