namespace Lab07.Tests;

public class Test4
{
    [Test]
    public void LinkedListStartingWithTwoTests()
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        Assert.AreEqual(2, list.Lenght);
        Assert.AreEqual(1, list.First.Data);
        Assert.AreEqual(2, list.Last.Data);
        Assert.AreEqual(null, list.First.Prev);
        Assert.AreEqual(null, list.Last.Next);
    }
}