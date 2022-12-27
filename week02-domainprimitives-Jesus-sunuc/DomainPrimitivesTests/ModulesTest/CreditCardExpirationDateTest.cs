using NUnit.Framework;
public class ExpirationDateTests
{
    [Test]
    public void CreateValidDate()
    {
        var date = ExpirationDate.Create(01, 01);
        Assert.IsNotNull(date);
    }

    [Test]
    public void CreateInvalidDate()
    {
        var date = ExpirationDate.Create(33, 997);
        Assert.IsNull(date);
    }
}