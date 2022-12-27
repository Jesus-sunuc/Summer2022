namespace Lab06.Tests;

public class TestsLinkedListNode
{
    public void SingleNodeTestWithNullInItsNext()
    {
        LinkedListNode<int> node = new LinkedListNode<int>(1);
        node.next = null;
        Assert.AreEqual(true, node.IsEnd());
    }

    public void TwoNodeTestWithNullInItsNextReturnsFalse()
    {
        LinkedListNode<int> node = new LinkedListNode<int>(1);
        LinkedListNode<int> node2 = new LinkedListNode<int>(2);
        node.next = node2;
        node2.next = null;
        Assert.AreEqual(false, node2.IsEnd());
    }

    public void LinkedListNodeInt()
    {
        LinkedListNode<int> node = new LinkedListNode<int>(1);
        Assert.AreEqual(1, node.data);
    }

    public void LInkedListNodeString()
    {
        LinkedListNode<string> node = new LinkedListNode<string>("Hi");
        Assert.AreEqual("Hi", node.data);
    }
}
