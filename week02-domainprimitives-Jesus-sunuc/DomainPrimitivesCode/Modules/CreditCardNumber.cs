public class CreditCardNumber
{
    private string Number { get; set; }

    private CreditCardNumber(string number)
    {
        Number = number;
    }

    public static CreditCardNumber? Create(string cardnumber)
    {
        if (IsOnlyNumbersAndSpace(cardnumber))
        {
            var newCardNumber = new CreditCardNumber(cardnumber);
            return newCardNumber;
        }
        return null;
    }

    private static bool IsOnlyNumbersAndSpace(string number)
    {

        if (number.Length != 19)
        {
            return false;
        }
        else if (HasLetters(number))
        {
            return false;
        }
        return true;
    }

    private static bool HasLetters(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            char letter = number[i];

            if (i != 4 && i != 9 && i != 14 )
            {
                if (!Char.IsLetter(letter))
                {
                    return false;
                }
            }
            else if(letter != ' ')
            {
                return false;
            }
        }
        return true;
    }
    public string GetConsoleString()
    {
        return Number;
    }
}