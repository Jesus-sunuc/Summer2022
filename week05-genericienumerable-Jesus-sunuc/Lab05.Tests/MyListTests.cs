using NUnit.Framework;
namespace Lab05;
public class Tests
{
    [Test]
    
    public void MyListWithIntergsTest()
    {
        int[] startingArray = { 1, 2, 3};
        var mylist = new MyList<int>(startingArray);
        CollectionAssert.AreEqual(mylist, new int[] { 1, 2, 3});
    }

    [Test]
    
    public void MyListWithIntergsTest2()
    {
        int[] startingArray = { 1, 2, 3};
        var mylist = new MyList<int>(startingArray);
        CollectionAssert.AreEqual(mylist, new int[] { 1, 2, 3});
        CollectionAssert.AreEqual(mylist, new int[] { 1, 2, 3});
    }

    [Test]
    
    public void MyListWithStrings()
    {
        string[] startingArray = { "x", "y", "z"};
        var mylist = new MyList<string>(startingArray);
        CollectionAssert.AreEqual(mylist, new string[] { "x", "y", "z"});
        CollectionAssert.AreEqual(mylist, new string[] { "x", "y", "z"});
    }
}