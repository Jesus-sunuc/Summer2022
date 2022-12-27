namespace Lab07.Tests;

public class Test1
{
    [Test]
    public void LinkedListStartingEmptyTests()
    {
        LinkedList list = new LinkedList();
        Assert.AreEqual(0, list.Lenght);
        Assert.AreEqual(null, list.First);
        Assert.AreEqual(null, list.Last);
    }
}