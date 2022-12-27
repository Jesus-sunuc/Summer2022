using NUnit.Framework;
public class NameTests
{
    [Test]
    public void UserNameWithMiddleName()
    {
        var fullName = Name.CreateWithMiddleName("Luis", "Josh", "Gomez");
        Assert.IsNotNull(fullName);
    }
    [Test]
    public void UserNameWithoutMiddleName()
    {
        var fullName = Name.CreateWithoutMiddleName("Santiago", "Alvarez");
        Assert.IsNotNull(fullName);
    }
}