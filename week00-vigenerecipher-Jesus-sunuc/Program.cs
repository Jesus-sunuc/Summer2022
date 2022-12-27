// Jesus Sunuc, 05/14/2022, First Lab
using System.Diagnostics;

class Program
{
    public static void RunTests()
    {
        TestIsLowercaseLetter();
        TestIsLowercaseString();
        TestCharShifted();
        TestEncodedMessage();
        Console.WriteLine("All tests passed.");
    }
    public static void Main()
    {
        RunTests();
        Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.");
        Console.WriteLine("Please enter the message:");
        Console.Write("     ");
        string userInput = Console.ReadLine();

        if (userInput.Length == 1)
        {
            char inputchar = userInput[0];
            if (IsLowercaseLetter(inputchar))
            {
                Console.WriteLine("Please enter an encryption key:");
                Console.Write("     ");
                string inputshift = Console.ReadLine();
                if (inputshift.Length == 1)
                {
                    char inputshiftedchar = inputshift[0];
                    if (IsLowercaseLetter(inputshiftedchar))
                    {
                        char newChar = ShiftChar(inputchar, inputchar);
                        Console.WriteLine("Here is the encrypted message:");
                        Console.Write("     " + newChar);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (inputshift.Length > 1)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        else if (userInput.Length > 1)
        {
            if (IsLowerCaseLetter(userInput))
            {
                Console.WriteLine("Please enter an encryption key:");
                Console.Write("     ");
                string inputshift = Console.ReadLine();

                if (IsLowerCaseLetter(inputshift))
                {
                    string newChar = EncodedMessage(userInput, inputshift);
                    Console.WriteLine("Here is the encrypted message:");
                    Console.Write("     " + newChar);
                }
                else
                {
                    Console.WriteLine("invalid Input, please use only Lowercase Characters");
                }
            }
            else
            {
                Console.WriteLine("invalid Input, please use only Lowercase leters");
            }
        }
    }
    static bool IsLowercaseLetter(char c)
    {
        if (c >= 97 && c <= 122)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool IsLowerCaseLetter(string a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (IsLowercaseLetter(a[i]) == false)
            {
                continue;
            }
            else
            {
                return true;
            }
        }
        return true;
    }

    static char ShiftChar(char d, char x)
    {
            int addValue = x - 97;
            char newChar = (char)(d + addValue);
            if (newChar > 126)
            {
                int exess = newChar - 126;
                newChar = (char)(31 + exess);
            }
            return newChar;
    }

    static string EncodedMessage(string y, string z)
    {
        char[] r = new char[y.Length];
        int w = 0;
        while (w < y.Length)
        {
            for (int i = 0; i < z.Length; i++)
            {
                r[w] = ShiftChar(y[w], z[i]);
                w++;
                if (w == y.Length)
                {
                    break;
                }
            }
        }
        string newString = new string(r);
        return newString;
    }

    static void TestIsLowercaseString()
    {
        Debug.Assert(IsLowerCaseLetter("hi"));
        Debug.Assert(IsLowerCaseLetter("Hi"));
        Debug.Assert(IsLowerCaseLetter("cEll"));
    }

    static void TestIsLowercaseLetter()
    {
        Debug.Assert(IsLowercaseLetter('a'));
        Debug.Assert(IsLowercaseLetter('b'));
        Debug.Assert(IsLowercaseLetter('z'));
        Debug.Assert(!IsLowercaseLetter('A'));
        Debug.Assert(!IsLowercaseLetter('`'));
        Debug.Assert(!IsLowercaseLetter('{'));
    }

    static void TestCharShifted()
    {
        Debug.Assert(ShiftChar('a', 'b') == 'b');
        Debug.Assert(ShiftChar('a', 'x') == 'x');
        Debug.Assert(ShiftChar('a', 'z') == 'z');
    }

    public static void TestEncodedMessage()
    {
        Debug.Assert(EncodedMessage("aaa", "bcb") == "bcb");
        Debug.Assert(EncodedMessage("aaa", "cdc") == "cdc");
        Debug.Assert(EncodedMessage("aaa", "ded") == "ded");
    }
}
