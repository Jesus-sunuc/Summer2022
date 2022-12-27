using NUnit.Framework;

public class CVVTests
{
    [Test]
    public void CreditCardValidInput()
    {
        var CVVNumber = CVV.Create("001");
        Assert.IsNotNull(CVVNumber);
    }

    [Test]
    public void CreditCardCVVInvalidInput()
    {
        var CVVNumber = CVV.Create("0120A22");
        Assert.IsNull(CVVNumber);
    }
}