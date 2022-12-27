// using NUnit.Framework;
// public class MixedNumberTests
// {
//     [Test]
//     public void MixedNumberWithWholeValue()
//     {
//         var mixedNumber = new MixedNumber(5,2);
//         Assert.True(mixedNumber.WholeUnits == 2);
//         Assert.True(mixedNumber.PartialUnits.Numerator == 1);
//         Assert.True(mixedNumber.PartialUnits.Denominator == 2);
//     }
    
//     [Test]
//     public void MixedNumberWithoutWholeValue()
//     {
//         var mixedNumber = new MixedNumber(1,2);
//         Assert.True(mixedNumber.WholeUnits == 0);
//         Assert.True(mixedNumber.PartialUnits.Numerator == 1);
//         Assert.True(mixedNumber.PartialUnits.Denominator == 2);
//     }

//     [Test]
//     public void AreEqual()
//     {
//         Assert.True(new RationalNumber(20,10).Equals(new RationalNumber(4,2)));
//     }
// }