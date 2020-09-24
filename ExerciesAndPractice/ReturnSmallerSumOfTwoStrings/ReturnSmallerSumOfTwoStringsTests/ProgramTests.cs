using NUnit.Framework;
using System;
using Program;
//using Xunit;

namespace ReturnSmallerSumOfTwoStringsTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase("21", "44", ExpectedResult = "21")]
        [TestCase("153", "367", ExpectedResult = "153")]
        [TestCase("1500", "16", ExpectedResult = "16")]
        [TestCase("100", "23", ExpectedResult = "23")]
        [TestCase("1500", "1", ExpectedResult = "1")]
        [TestCase("5", "5", ExpectedResult = "5")]
        public void SmallerNumTest(string n1, string n2)
        {
            return Program.SmallerNum(n1, n2);
        }
    }
}
