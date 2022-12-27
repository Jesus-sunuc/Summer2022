using NUnit.Framework;
public class RationalNumberTests
{

    [Test]
    public void Add()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);
        var product = number1 +  number2;
        var expectedProduct = new RationalNumber(3,3);

        Assert.AreEqual(expectedProduct,product);
    }
        [Test]
    public void Substract()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);
        var product = number1 - number2;
        var expectedProduct = new RationalNumber(1,3);

        Assert.AreEqual(expectedProduct,product);
    }

     [Test]
    public void Multiply()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);
        var product = number1 * number2;
        var expectedProduct = new RationalNumber(2,9);

        Assert.AreEqual(expectedProduct,product);
    }
    [Test]
    public void Divide()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);
        var product = number1 / number2;
        var expectedProduct = new RationalNumber(6,3);

        Assert.AreEqual(expectedProduct,product);
    }
    
    [Test]
    public void Smaller()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);

        Assert.True(number2 < number1);
    }
    [Test]
    
   public void Greater()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);

        Assert.True(number1 > number2);
    }
    [Test]
    
    public void Equals()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(2,3);

        Assert.True(number1 == number2);
    }
    
        [Test]
    public void NotEquals()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);

        Assert.True(number1 != number2);
    }
    [Test]
    public void SmallerEqual()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);
        var number3 = new RationalNumber(2,3);

        Assert.True(number2 <= number1 && number1 <= number3);
    }
    
    [Test]
    public void GreaterEqual()
    {
        var number1 = new RationalNumber(2,3);
        var number2 = new RationalNumber(1,3);
        var number3 = new RationalNumber(2,3);

        Assert.True(number1 >= number2 && number1 >= number3);
    }
}