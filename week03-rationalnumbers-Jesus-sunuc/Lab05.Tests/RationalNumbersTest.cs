using NUnit.Framework;
public class RationalNumberTests
{

    [Test]
    public void NumeratorAndDenominatorPositive()
    {
        var rationalNumber = new RationalNumber(24, 18);
        Assert.AreEqual(rationalNumber.Numerator, 24);
        Assert.AreEqual(rationalNumber.Denominator, 18);
    }

    [Test]
    public void PositiveNumeratorAndNegativeDenominator()
    {
        var rationalNumber = new RationalNumber(24, -18);
        Assert.AreEqual(rationalNumber.Numerator, 24);
        Assert.AreEqual(rationalNumber.Denominator, -18);
    }

    [Test]
    public void NegativeNumeratorAndDenominator()
    {
        var rationalNumber = new RationalNumber(-24, -18);
        Assert.AreEqual(rationalNumber.Numerator, -24);
        Assert.AreEqual(rationalNumber.Denominator, -18);
    }

    [Test]
    public void NonSimplfy()
    {
        var rationalNumber = new RationalNumber(7, 9);
        Assert.AreEqual(rationalNumber.Numerator, 7);
        Assert.AreEqual(rationalNumber.Denominator, 9);
    }

    [Test]
    public void AreEqual()
    {
        Assert.True(new RationalNumber(20,10).Equals(new RationalNumber(4,2)));
    }
}