public class CreditCard
{
    private CreditCardNumber CardNumber { get; }
    private ExpirationDate ExpirationDate { get; }
    private CVV CVV { get; }
    private CreditCard(CreditCardNumber cardNumber, ExpirationDate expirationDate, CVV cVV)
    {
        CardNumber = cardNumber;
        ExpirationDate = expirationDate;
        CVV = cVV;
    }

    public static CreditCard? Create(CreditCardNumber? creditCardNumber, ExpirationDate? date, CVV? cVVNumber)
    {
        if (NumberIsNotNull(creditCardNumber) && DateIsNotNull(date) && CVVIsNotNull(cVVNumber))
        {
            return new CreditCard(creditCardNumber!, date!, cVVNumber!);
        }
        return null;
    }

    private static bool CVVIsNotNull(CVV? cVVNumber)
    {
        if (cVVNumber != null)
        {
            return true;
        }
        return false;
    }

    private static bool DateIsNotNull(ExpirationDate? date)
    {
        if (date != null)
        {
            return true;
        }
        return false;
    }

    private static bool NumberIsNotNull(CreditCardNumber? creditCardNumber)
    {
        if (creditCardNumber != null)
        {
            return true;
        }
        return false;
    }

    public string GetConsoleString()
    {
        return "Credit card number: " + CardNumber + "\r\n" + "Expiration date: " + ExpirationDate + "\r\n" + "CVV: " + CVV;

    }
}