using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab06;

public class MyListEnumerator<T> : IEnumerator<T>
{
    private LinkedListNode<T> current;
    private LinkedList<T> List;
    public MyListEnumerator(LinkedList<T> list)
    {
        List = list;
        // current = list.head;
        current = null;
    }
    
    public T Current
    {
        get
        {
            return current.data;
        }
    }
    
    object IEnumerator.Current
    {
        get
        {
            return current.data;
        }
    }
    
    public void Dispose()
    {
        current = null;
        List = null;
    }

    public bool MoveNext()
    {
        if (current.next == null)
        {
            return false;
        }
        else
        {
            current = current.next;
            return true;
        }
    }

    public void Reset()
    {
        // current = List.head;
        current = null;
    }
}