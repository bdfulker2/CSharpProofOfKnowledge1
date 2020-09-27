using System;
using NUnit.Framework;
using ArrayOfMultiples;


namespace ArrayOfMultiplesTests
{
    [TestFixture]
    public class ArrayOfMultiplesTests
    {
       
        [Test]
        [TestCase(7,5, ExpectedResult = new int[] { 7, 14, 21, 28, 35})]
        [TestCase(12, 10, ExpectedResult = new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 })]
        [TestCase(17, 7, ExpectedResult = new int[] { 17, 34, 51, 68, 85, 102, 119 })]
        [TestCase(630, 14, ExpectedResult = new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 })]
        [TestCase(140, 3, ExpectedResult = new int[] { 140, 280, 420 })]
        [TestCase(7, 8, ExpectedResult = new int[] { 7, 14, 21, 28, 35, 42, 49, 56 })]
        [TestCase(11, 21, ExpectedResult = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 })]
        public int[] ArrayOfMultiplesTest(int num, int length)
        {
            ArrayOfMultiple multiples = new ArrayOfMultiple();
            return multiples.ArrayOfMulitples(num, length);
        }
    }
}
