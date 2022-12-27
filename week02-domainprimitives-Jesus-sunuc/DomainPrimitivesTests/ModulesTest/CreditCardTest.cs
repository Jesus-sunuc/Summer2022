using NUnit.Framework;
public class CreditCardTests
{
    [Test]
    public static void CreditCardTestValidInput()
    {
        var creditCardNumber = CreditCardNumber.Create("3453 3534 3432 6456");
        var numberCVV = CVV.Create("567");
        var dateCretidCard = ExpirationDate.Create(01, 01);
        CreditCard creditCard = CreditCard.Create(creditCardNumber, dateCretidCard, numberCVV)!;
        Assert.IsNotNull(creditCard);
    }

    [Test]
    public static void CreditCardTestInvalidInput()
    {
        var creditCardNumber = CreditCardNumber.Create("2323 23232 2323 232");
        var numberCVV = CVV.Create("44");
        var dateCretidCard = ExpirationDate.Create(126, 999);
        CreditCard creditCard = CreditCard.Create(creditCardNumber, dateCretidCard, numberCVV)!;
        Assert.IsNull(creditCard);
    }
}