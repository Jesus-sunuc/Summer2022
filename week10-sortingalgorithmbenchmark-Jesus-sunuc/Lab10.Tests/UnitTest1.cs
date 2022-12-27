namespace Lab10.Tests;
public class Tests
{
    [Test]
    public void TestSelectionSort()
    {
        int[] values = { 3, 1, 2, 4, 5, 6, 7, 8, 9, 10 };
        SelectionSort1.SelectionSort(values);
        Assert.AreEqual(1, values[0]);
        Assert.AreEqual(2, values[1]);
        Assert.AreEqual(3, values[2]);
        Assert.AreEqual(4, values[3]);
        Assert.AreEqual(5, values[4]);
        Assert.AreEqual(6, values[5]);
        Assert.AreEqual(7, values[6]);
        Assert.AreEqual(8, values[7]);
        Assert.AreEqual(9, values[8]);
        Assert.AreEqual(10, values[9]);
    }

    [Test]
    public void TestQuickSort()
    {
        int[] values = { 3, 1, 2, 4, 5, 6, 7, 8, 9, 10 };
        QuickSortClass.QuickSort(values, 0, values.Length - 1);
        Assert.AreEqual(1, values[0]);
        Assert.AreEqual(2, values[1]);
        Assert.AreEqual(3, values[2]);
        Assert.AreEqual(4, values[3]);
        Assert.AreEqual(5, values[4]);
        Assert.AreEqual(6, values[5]);
        Assert.AreEqual(7, values[6]);
        Assert.AreEqual(8, values[7]);
        Assert.AreEqual(9, values[8]);
        Assert.AreEqual(10, values[9]);
    }
}
