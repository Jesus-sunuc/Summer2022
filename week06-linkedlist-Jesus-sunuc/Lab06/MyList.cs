using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab06;

public class MyList<T> : IEnumerable<T>
{
    public LinkedListNode<T> head;
    public LinkedListNode<T> tail;
    public int count;
    public MyList()
    {
        head = null;
        tail = null;
        count = 0;
    }
    public void AddNodeToFront(T data)
    {
        LinkedListNode<T> node = new LinkedListNode<T>(data);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            node.next = head;
            head = node;
        }
        count++;
    }
    public void AddNodeToBack(T data)
    {
        LinkedListNode<T> node = new LinkedListNode<T>(data);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }
    public void PrintList()
    {
        LinkedListNode<T> runner = head;
        while (runner != null)
        {
            Console.Write(runner.data);
            runner = runner.next;
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return new MyListEnumerator<T>(this);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new MyListEnumerator<T>(this);
    }
}