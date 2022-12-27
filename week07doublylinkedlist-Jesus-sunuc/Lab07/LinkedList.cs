using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab07;

public class LinkedList : IEnumerable
{
    private Node head;
    public Node First
    {
        get { return head; }
    }

    private Node tail;

    public Node Last
    {
        get { return tail; }
    }

    public int Lenght { get; private set; }

    public IEnumerable<Node> GetEnumerable()
    {
        Node current = head;
        while (current != null)
        {
            yield return current;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerable().GetEnumerator();
    }

    public IEnumerable GetEnumeratorReverse()
    {
        Node current = tail;
        while (current != null)
        {
            yield return current;
            current = current.Prev;
        }
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
        Lenght++;
    }

    public void AddFirst(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        Lenght++;
    }

    public void AddLast(int data)
    {
        Add(data);
    }

    public bool Contains(int value)
    {
        foreach (Node node in GetEnumerable())
        {
            if (node.Data == value)
            {
                return true;
            }
        }
        return false;
    }

    public Node Find(int value)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == value)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public Node FindLast(int value)
    {
        Node current = tail;
        while (current != null)
        {
            if (current.Data == value)
            {
                return current;
            }
            current = current.Prev;
        }
        return null;
    }
    
    public void Remove(int value)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == value)
            {
                if (current == head)
                {
                    head = current.Next;
                }
                if (current == tail)
                {
                    tail = current.Prev;
                }
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                Lenght--;
                break;
            }
            current = current.Next;
        }
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }
            else
            {
                tail = null;
            }
            Lenght--;
        }
    }

    public void RemoveLast()
    {
        if (tail != null)
        {
            tail = tail.Prev;
            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }
            Lenght--;
        }
    }
}