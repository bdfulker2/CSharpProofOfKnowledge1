using System;
using NUnit.Framework;
using SixDigitHexValidation;

namespace SixDigitHexValidationTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase("#CD5C5C", ExpectedResult = true)]
        [TestCase("#EAECEE", ExpectedResult = true)]
        [TestCase("#eaecee", ExpectedResult = true)]
        [TestCase("#CD5C58C", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#CD5C5Z", ExpectedResult = false, Description = "Alphabetic characters not in A-F.")]
        [TestCase("#CD5C&C", ExpectedResult = false, Description = "Unacceptable character.")]
        [TestCase("CD5C5C", ExpectedResult = false, Description = "Does not start with #.")]
        [TestCase("#123CCCD", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#123456", ExpectedResult = true)]
        [TestCase("#987654", ExpectedResult = true)]
        [TestCase("#9876543", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#CCCCCC", ExpectedResult = true)]
        [TestCase("#ZCCZCC", ExpectedResult = false, Description = "Not acceptable alphabetic characters.")]
        [TestCase("#Z88Z99", ExpectedResult = false, Description = "Not acceptable alphabetic characters.")]
        [TestCase("#Z88!99", ExpectedResult = false, Description = "Unacceptable character.")]
        public bool ValidateSixDigitHexCodeTest(string hexCode)
        {
            IsValidHexCode sixDigHexValidation = new IsValidHexCode();
            Console.WriteLine($"Input : {hexCode}");
            return sixDigHexValidation.ValidateSixDigitHexCode(hexCode);
        }
    }
}
