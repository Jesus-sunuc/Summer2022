namespace Lab07;

public class Node
{
    private int _data;

    public int Data
    {
        get { return _data; }
        set { _data = value; }
    }

    private Node _next;
    public Node Next
    {
        get { return _next; }
        set { _next = value; }
    }

    private Node _prev;
    public Node Prev
    {
        get { return _prev; }
        set { _prev = value; }
    }

    public Node(int data)
    {
        _data = data;
    }
}