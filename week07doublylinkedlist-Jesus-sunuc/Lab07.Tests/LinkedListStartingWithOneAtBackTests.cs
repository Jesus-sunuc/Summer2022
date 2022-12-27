namespace Lab07.Tests;

public class Test2
{
    [Test]
    public void LinkedListStartingWithOneAtBackTests()
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        Assert.AreEqual(1, list.Lenght);
        Assert.AreEqual(1, list.First.Data);
        Assert.AreEqual(1, list.Last.Data);
        Assert.AreEqual(null, list.First.Next);
        Assert.AreEqual(null, list.First.Prev);
        Assert.AreEqual(null, list.Last.Next);
        Assert.AreEqual(null, list.Last.Prev);
    }
}