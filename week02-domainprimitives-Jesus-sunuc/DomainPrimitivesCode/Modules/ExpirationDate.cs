public class ExpirationDate
{
    private uint Month { get; set; }
    private uint Date { get; set; }

    private ExpirationDate(uint month, uint date)
    {
        Month = month;
        Date = date;
    }

    public static ExpirationDate? Create(uint month, uint date)
    {
        if (MonthIsValid(month) && DateIsValid(date))
        {
            return new ExpirationDate(month, date);
        }
        return null;
    }

    private static bool MonthIsValid(uint month)
    {
        if (month <= 12 && month > 0)
        {
            return true;
        }
        return false;
    }

    private static bool DateIsValid(uint date)
    {
        if (date <= 30 && date > 0)
        {
            return true;
        }
        return false;
    }
    public string GetConsoleString()
    {
        string consoleString = Month + "/" + Date;
        return consoleString;
    }
}