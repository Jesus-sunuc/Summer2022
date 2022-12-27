class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the rational number reducer.");
        Console.WriteLine("Please enter a number");
        int numerator = InputUser();
        int denominator = InputUser();
        var rationalNumberReduced = new RationalNumber(numerator, denominator);
        Console.WriteLine($"Here is the answer: " + rationalNumberReduced.Numerator + " / " + rationalNumberReduced.Denominator);
    }

    private static int InputUser()
    {
        int input = 0;
        do
        {
            try
            {
                input = int.Parse(Console.ReadLine()!);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input");
            }
            
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input");
            }

            if (input == 0)
            {
                Console.WriteLine("0 is an invalid input. Please enter another number.");
            }

        } while (input == 0);
        Console.WriteLine("Please enter another number.");
        return input;
    }
}