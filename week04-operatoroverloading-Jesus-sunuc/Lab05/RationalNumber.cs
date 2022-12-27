public class RationalNumber
{
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

    private static int GreatestCommonNumerator(int numerator, int denominator)
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

    public int Numerator { get; }
    public int Denominator { get; }
    static int GreatestCommonDenominator(int w, int y)
    {
        do
        {
            for (int i = w; i > 1; i--)
            {
                if (w % i == 0 && y % i == 0)
                {
                    int z = i;
                    return z;
                }
            }
            break;
        } while (true);
        return y;
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
      public static bool operator >=(RationalNumber a, RationalNumber b)
    {
        var newRational = a - b;
        if(newRational.Numerator > 0 || a == b)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }
     public static bool operator <=(RationalNumber a, RationalNumber b)
    {
        var newRational = a - b;
        if(newRational.Numerator < 0 || a == b)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }
    public static RationalNumber operator -(RationalNumber a, RationalNumber b)
    {
        var newDenominator = GreatestCommonDenominator(a.Denominator, b.Denominator);
        var newNumerator = SubstractNumeratorsBasedOnDenominator(a, b, newDenominator);
        return new RationalNumber(newNumerator, newDenominator);
    }

    public static bool operator !=(RationalNumber a, RationalNumber b)
    {
        if(a.Numerator != b.Numerator || a.Denominator != b.Denominator)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }
    public static bool operator ==(RationalNumber a, RationalNumber b)
    {
        if(a.Numerator == b.Numerator && a.Denominator == b.Denominator)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }
    public static bool operator <(RationalNumber a, RationalNumber b)
    {
        var newRational = a - b;
        if(newRational.Numerator < 0)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }
    
    public static bool operator >(RationalNumber a, RationalNumber b)
    {
        var newRational = a - b;
        if(newRational.Numerator > 0)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }
    public static RationalNumber operator *(RationalNumber a, RationalNumber b)
    {
        return new RationalNumber(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }
    public static RationalNumber operator /(RationalNumber a, RationalNumber b)
    {
        return new RationalNumber(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    private static int SubstractNumeratorsBasedOnDenominator(RationalNumber a, RationalNumber b, int newDenominator)
    {
        if (a.Denominator == newDenominator && b.Denominator == newDenominator)
        {
            return a.Numerator - b.Numerator;
        }
        else if (a.Denominator == newDenominator && b.Denominator != newDenominator)
        {
            return a.Numerator - (GreatestCommonNumerator(b.Numerator, newDenominator));
        }
        else if (b.Denominator == newDenominator && a.Denominator != newDenominator)
        {
            return b.Numerator - (GreatestCommonNumerator(a.Numerator, newDenominator));
        }
        else
        {
            return GreatestCommonNumerator(a.Numerator, newDenominator) - GreatestCommonNumerator(b.Numerator, newDenominator);
        }
    }

    public static RationalNumber operator +(RationalNumber a, RationalNumber b)
    {
        var newDenominator = GreatestCommonDenominator(a.Denominator, b.Denominator);
        var newNumerator = AddNumeratorsBasedOnDenominator(a, b, newDenominator);
        return new RationalNumber(newNumerator, newDenominator);
    }

    private static int AddNumeratorsBasedOnDenominator(RationalNumber a, RationalNumber b, int newDenominator)
    {
        if (a.Denominator == newDenominator && b.Denominator == newDenominator)
        {
            return a.Numerator + b.Numerator;
        }
        else if (a.Denominator == newDenominator && b.Denominator != newDenominator)
        {
            return a.Numerator + (GreatestCommonNumerator(b.Numerator, newDenominator));
        }
        else if (b.Denominator == newDenominator && a.Denominator != newDenominator)
        {
            return b.Numerator + (GreatestCommonNumerator(a.Numerator, newDenominator));
        }
        else
        {
            return GreatestCommonNumerator(a.Numerator, newDenominator) + GreatestCommonNumerator(b.Numerator, newDenominator);
        }
    }
}
