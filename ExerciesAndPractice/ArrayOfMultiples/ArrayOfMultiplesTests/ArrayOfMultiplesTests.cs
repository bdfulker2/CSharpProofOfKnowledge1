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
        public int[] ArrayOfMultiplesTest(int num, int length)
        {
            ArrayOfMultiple multiples = new ArrayOfMultiple();
            return multiples.ArrayOfMulitples(num, length);
        }
    }
}
