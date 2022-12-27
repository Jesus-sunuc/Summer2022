public class MixedNumber
{
    public int Numerator { get; }
    public int Denominator { get; }
    public RationalNumber RationalNumberCreate { get; }

    public MixedNumber(int numerator, int denominator)
    {
        new MixedNumber(new RationalNumber( numerator, denominator));
    }

    public MixedNumber(RationalNumber rationalNumber)
    {
        RationalNumberCreate = rationalNumber;
    }

    public int WholeUnits
    {
         get
        {
            if (RationalNumberCreate.Numerator / RationalNumberCreate.Denominator > 0)
            {
                return RationalNumberCreate.Numerator / RationalNumberCreate.Denominator;
            }
            else
            {
                return 0;
            }
        }
    }

    public RationalNumber PartialUnits
    {
         get
        {
            if (RationalNumberCreate.Numerator % RationalNumberCreate.Denominator > 0)
            {
                return new RationalNumber(RationalNumberCreate.Numerator - WholeUnits * RationalNumberCreate.Denominator , RationalNumberCreate.Denominator);
            }
            else
            {
                return new RationalNumber(0,0);
            }
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {  
            return false;
        }

        var objMixedNumbers = (MixedNumber)obj;
        if (objMixedNumbers == null)
        {
            return false;
        }

        return objMixedNumbers.WholeUnits == Numerator && objMixedNumbers.Denominator == Denominator && objMixedNumbers.RationalNumberCreate == RationalNumberCreate;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return $"Numerator: {Numerator}, Denominator: {Denominator}";
    }
}