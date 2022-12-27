using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab06;
public class LinkedListNode<T>
{
    public T data;
    public LinkedListNode<T> next;
    LinkedListNode<T> head;
    public LinkedListNode(T x)
    {
        data = x;
    }
    public bool IsEnd()
    {
        return next == null;
    }
}