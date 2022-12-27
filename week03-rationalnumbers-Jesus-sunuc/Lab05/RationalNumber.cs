public class RationalNumber
{
    public int Numerator { get; }
    public int Denominator { get; }

    public RationalNumber(int numerator, int denominator)
    {
        if (numerator % denominator == 0)
        {
            Numerator = GreatestCommonNumerator(numerator, GreatestCommonDenominator(numerator, denominator));
            Denominator = denominator / GreatestCommonDenominator(numerator, denominator);
        }
        else
        {
            Numerator = numerator;
            Denominator = denominator;
        }
    }

    private int GreatestCommonNumerator(int numerator, int denominator)
    {
        if (numerator % GreatestCommonDenominator(numerator, denominator) == 0)
        {
            return numerator / denominator;
        }
        else
        {
            return numerator % GreatestCommonDenominator(numerator, denominator);
        }
    }

    static int GreatestCommonDenominator(int y, int z)
    {
        do
        {
            for (int i = y; i > 1; i--)
            {
                if (y % i == 0 && z % i == 0)
                {
                    int x = i;
                    return x;
                }
            }
            break;
        } while (true);
        
        return z;
    }

    public override bool Equals(object? obj)
    {
        return obj is RationalNumber number &&
               Numerator == number.Numerator &&
               Denominator == number.Denominator;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Numerator, Denominator);
    }
}

