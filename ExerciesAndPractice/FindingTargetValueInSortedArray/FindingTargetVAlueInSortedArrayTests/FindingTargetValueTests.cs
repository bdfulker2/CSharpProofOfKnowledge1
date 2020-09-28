using System;
using NUnit.Framework;
using FindingTargetValueInSortedArray;

namespace FindingTargetVAlueInSortedArrayTests
{
    [TestFixture]
    public class FindingTargetValueTests
    {
        [Test]
        [TestCase(10, new int[] {1, 3, 4, 5, 6, 8, 10, 11, 12, 14 },  ExpectedResult = true)]
        public bool FindTargetValueInArrayTest(int target, int[] arrayOfValues)
        {
            FindingTargetValue targetValue = new FindingTargetValue();
            return targetValue.FindTargetValueInArray(target, arrayOfValues);
        }
    }
}