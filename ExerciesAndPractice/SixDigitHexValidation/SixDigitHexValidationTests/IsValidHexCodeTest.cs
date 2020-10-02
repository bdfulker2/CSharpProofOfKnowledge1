using System;
using NUnit.Framework;
using SixDigitHexValidation;

namespace SixDigitHexValidationTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void IsValidHexCodeTest(string hexCode)
        {
            IsValidHexCode sixDigHexValidation = new IsValidHexCode();
            Console.WriteLine($"Input : {hexCode}");
            return sixDigHexValidation.IsValidHexCode(hexCode);
        }
    }
}
