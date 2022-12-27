public class CVV
{
    private string CVVNumber { get; set; }
    private CVV(string cvvnumber)
    {
        CVVNumber = cvvnumber;
    }

    public static CVV? Create(string CVVnumber)
    {
        if (IsNumberValid(CVVnumber))
        {
            return new CVV(CVVnumber);
        }
        return null;
    }

    private static bool IsNumberValid(string CVVnumber)
    {
        if (CVVnumber.Length == 3)
        {
            return true;
        }
        return false;
    }
    public string GetConsoleString()
    {
        return CVVNumber;
    }
}