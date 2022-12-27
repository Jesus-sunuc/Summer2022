using NUnit.Framework;

public class CreditCardNumberTests
{
    [Test]
    public static void ValidCreateTest()
    {
        var creditCardNumber = CreditCardNumber.Create("3434 4343 2323 5633");
        Assert.IsNotNull(creditCardNumber);
    }

    [Test]
    public static void InvalidCreateTest()
    {
        var creditCardNumber = CreditCardNumber.Create("43434 3333 43434 3444444");
        Assert.IsNull(creditCardNumber);
    }
}