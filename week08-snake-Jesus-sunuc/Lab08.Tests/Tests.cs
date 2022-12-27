using NUnit.Framework;
namespace Lab08.Tests;

public class Tests
{
    [Test]
    public void TestToCheckIfInitialCoordinatesAreGood()
    {
        Snake TestSnake = new Snake();
        Assert.AreEqual(TestSnake.SnakeHeadRow, 5);
        Assert.AreEqual(TestSnake.SnakeHeadColumn, 5);
    }

    [Test]
    public void TestToCheckInicialCoordinates()
    {
        Snake TestSnake = new Snake();
        Assert.AreEqual(TestSnake.PreviousCoordinates[0].Item1, 0);
        Assert.AreEqual(TestSnake.PreviousCoordinates[0].Item2, 0);
    }

    [Test]
    public void TestToCheckIncialDireactionAreTrue()
    {
        Snake TestSnake = new Snake();
        Assert.AreEqual(TestSnake.SnakeDirection.MyDirection, Directions.Direction.East);
    }

    [Test]
    public void TestToCheckIncialSizeIsGood()
    {
        Snake TestSnake = new Snake();
        Assert.AreEqual(TestSnake.SnakeSize, 0);
    }

    [Test]
    public void TestToCheckIncialFruitAreEaten()
    {
        Snake TestSnake = new Snake();
        Assert.AreEqual(TestSnake.FruitsEaten, 0);
    }

    [Test]
    public void TestFruitBoardAreSameSnakeBoard()
    {
        Snake TestSnake = new Snake();
        Fruits TestFruit = new Fruits(TestSnake.SnakeBoard);
        Assert.AreEqual(TestSnake.SnakeBoard, TestFruit.board);
    }

    [Test]
    public void TestToCheckAutomaticMover()
    {
        Snake TestSnake = new Snake();
        TestSnake.AutomaticSnakeMover();
        Assert.AreEqual(TestSnake.SnakeHeadColumn, 6);
    }

    [Test]
    public void TestToCheckAutomaticMoverWorks()
    {
        Snake TestSnake = new Snake();
        TestSnake.SnakeDirection.MyDirection = Directions.Direction.North;
        TestSnake.AutomaticSnakeMover();
        Assert.AreEqual(TestSnake.SnakeHeadRow, 4);
    }

    [Test]
    public void TestToCheckDefautlMapsHaveNoFruits()
    {
        Snake TestSnake = new Snake();
        Fruits TestFruit = new Fruits(TestSnake.SnakeBoard);
        Assert.False(TestFruit.IsThereAnotherFruitOnBoard(TestSnake.SnakeBoard));
    }

    [Test]
    public void TestToChecFruitplacerWorks()
    {
        Snake TestSnake = new Snake();
        Fruits TestFruit = new Fruits(TestSnake.SnakeBoard);
        TestFruit.FruitPlacer();
        Assert.True(TestFruit.IsThereAnotherFruitOnBoard(TestSnake.SnakeBoard));
    }
}