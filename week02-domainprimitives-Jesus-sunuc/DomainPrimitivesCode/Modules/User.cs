public class User
{
    private Name Name { get; }
    private CreditCard Creditcard { get; }
    private User(Name name, CreditCard creditcard)
    {
        Name = name;
        Creditcard = creditcard;
    }

    public static User? Create(Name name, CreditCard creditCard)
    {
        if (NameIsNotNull(name) && CreditCardIsNotNull(creditCard))
        {
            return new User(name, creditCard);
        }
        return null;
    }

    private static bool CreditCardIsNotNull(CreditCard creditCard)
    {
        if (creditCard != null)
        {
            return true;
        }
        return false;
    }

    private static bool NameIsNotNull(Name name)
    {
        if (name != null)
        {
            return true;
        }
        return false;
    }

    public string GetConsoleString()
    {
        return "User name: " + Name.GetConsoleString() + "\r\n" + "User credit card: " + Creditcard.GetConsoleString();
    }
}