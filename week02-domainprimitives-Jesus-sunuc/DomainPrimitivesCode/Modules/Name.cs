public class Name
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string? MiddleName { get; set; }

    private Name(string firstName, string lastName, string? middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }

    public static Name? CreateWithMiddleName(string firstName, string lastName, string? middleName)
    {
        if (IsValidFirstName(firstName) && IsValidLastName(lastName) && IsValidMiddleName(middleName!))
        {
            Name name = new Name(firstName, lastName, middleName);
            return name;
        }
        return null;
    }
    public static Name? CreateWithoutMiddleName(string firstName, string lastName)
    {
        if (IsValidFirstName(firstName) && IsValidLastName(lastName))
        {
            Name name = new Name(firstName, lastName, null);
            return name;
        }
        return null;
    }

    public static bool IsValidFirstName(string nameInput)
    {
        return IsValidInput(nameInput);
    }

    public static bool IsValidLastName(string nameInput)
    {
        return IsValidInput(nameInput);
    }

    public static bool IsValidMiddleName(string nameInput)
    {
        return IsValidInput(nameInput);
    }
    private static bool IsValidInput(string nameInput)
    {
        for (int i = 0; i < nameInput.Length; i++)
        {
            if (nameInput[i] > 141 && nameInput[i] < 172)
            {
                return true;
            }
            else if (nameInput[i] > 101 && nameInput[i] < 132)
            {
                return true;
            }
        }
        return false;
    }
    public string GetConsoleString()
    {
        if (MiddleName != null)
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
        else
        {

            return FirstName + " " + LastName;
        }
    }
}