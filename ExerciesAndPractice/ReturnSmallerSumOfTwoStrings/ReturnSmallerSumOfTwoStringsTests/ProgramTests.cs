using NUnit.Framework;
//using System;
using ReturnSmallerSumOfTwoStrings;
using System.Diagnostics;
//using Xunit;

namespace ReturnSmallerSumOfTwoStringsTests
{
    [TestFixture]
    public static class ProgramTests
    {
        [Test]
        [TestCase("21", "44", ExpectedResult = "21")]
        [TestCase("153", "367", ExpectedResult = "153")]
        [TestCase("1500", "16", ExpectedResult = "16")]
        [TestCase("100", "23", ExpectedResult = "23")]
        [TestCase("1500", "1", ExpectedResult = "1")]
        [TestCase("5", "5", ExpectedResult = "5")]
        public static string SmallerNumTest(string n1, string n2)
        {
            return Program.SmallerNum(n1, n2);
        }

        [Test]
        [TestCase("21", "44", ExpectedResult = "21")]
        [TestCase("153", "367", ExpectedResult = "153")]
        [TestCase("1500", "16", ExpectedResult = "16")]
        [TestCase("100", "23", ExpectedResult = "23")]
        [TestCase("1500", "1", ExpectedResult = "1")]
        [TestCase("5", "5", ExpectedResult = "5")]
        [TestCase("00001", "23", ExpectedResult = "00001")]
        [TestCase("001500", "1", ExpectedResult = "1")]
        [TestCase("000005", "5", ExpectedResult = "5")]
        public static string SmallerStringNumNoIntParsedTest(string n1, string n2)
        {
            return Program.SmallerStringNumNoIntParsed(n1, n2);
        }
    }
}
