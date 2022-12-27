class program
{
    public static void Main()
    {
        User user;
        Name userName;
        CreditCard creditCard;
        CreditCardNumber creditCardNumber;
        ExpirationDate creditCardExpirationDate;
        CVV cVV;

        Greetings();
        userName = createUserName();
        creditCardNumber = createCreditCardNumber();
        creditCardExpirationDate = createCreditCardExpirationDate();
        cVV = createCreditCardCVV();

        creditCard = CreditCard.Create(creditCardNumber, creditCardExpirationDate, cVV)!;
        user = User.Create(userName, creditCard)!;

        End(user);
    }

    private static void End(User user)
    {
        Console.Clear();
        Console.WriteLine("Here is your information.");
        Console.WriteLine(user.GetConsoleString());
    }

    private static CVV createCreditCardCVV()
    {
        CVV cVV = CVV.Create("")!;
        Console.WriteLine("Please enter your CVV");
        do
        {
            Console.WriteLine("Please write the month of your credit card.");
            string cVVInput = Console.ReadLine()!;
            cVV = CVV.Create(cVVInput)!;
            if (cVV == null)
            {
                Console.WriteLine("Something went wrong, Please try it again.");
            }

        } while (cVV == null);
        return cVV;
    }

    private static ExpirationDate createCreditCardExpirationDate()
    {
        ExpirationDate expirationDate = ExpirationDate.Create(0, 0)!;
        uint month = 0;
        uint date = 0;
        Console.WriteLine("Please enter your credit card expiration.");
        do
        {
            Console.WriteLine("Please enter the month of your credit card.");
            try
            {
                month = uint.Parse(Console.ReadLine()!);

            }
            catch (System.Exception)
            {
                Console.WriteLine("Something went wrong, Please try it again.");
                continue;
            }
            Console.WriteLine("Please enter the date of your credit card.");

            try
            {
                date = uint.Parse(Console.ReadLine()!);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Something went wrong, Please try it again.");
                continue;
            }

            expirationDate = ExpirationDate.Create(month, date)!;
            if (expirationDate == null)
            {
                Console.WriteLine("Something went wrong, Please try it again.");
            }
        } while (expirationDate == null);
        return expirationDate;
    }

    private static CreditCardNumber createCreditCardNumber()
    {
        CreditCardNumber creditCardNumber = CreditCardNumber.Create("")!;
        Console.WriteLine("Please enter your credit card number");
        do
        {
            Console.WriteLine("Please write the number (You need spaces between each four numbers).");
            string creditCardNumberInput = Console.ReadLine()!;
            creditCardNumber = CreditCardNumber.Create(creditCardNumberInput)!;
            if (creditCardNumber == null)
            {
                Console.WriteLine("Something went wrong, Please try it again.");
            }
        } while (creditCardNumber == null);
        return creditCardNumber;
    }

    private static Name createUserName()
    {
        Name userName = Name.CreateWithMiddleName("", "", "")!;
        Console.WriteLine("Please write \"Yes\" if you have a middle name, if not, write \"No\".");
        do
        {
            string input = Console.ReadLine()!;
            switch (input)
            {
                case "Yes":
                case "yes":
                    Console.WriteLine("Please enter the first name");
                    string firstName = Console.ReadLine()!;
                    Console.WriteLine("Please enter the middle name");
                    string middleName = Console.ReadLine()!;
                    Console.WriteLine("Please enter the last name");
                    string lastName = Console.ReadLine()!;
                    userName = Name.CreateWithMiddleName(firstName, lastName, middleName)!;
                    break;

                case "No":
                case "no":
                    Console.WriteLine("Please enter the first name");
                    firstName = Console.ReadLine()!;
                    Console.WriteLine("Please enter the last name");
                    lastName = Console.ReadLine()!;
                    userName = Name.CreateWithoutMiddleName(firstName, lastName)!;
                    break;
            }
            if (userName == null)
            {
                Console.WriteLine("Error, please try it again.");
            }
        } while (userName == null);
        return userName;
    }

    private static void Greetings()
    {
        Console.WriteLine("Welcome to the Domain Primitives program.");
        Console.WriteLine("You are going to be able to add your user name, middle name, last name, and more information.-");
    }
}