using System;
using NUnit.Framework;
using FindingTargetValueInSortedArray;

namespace FindingTargetVAlueInSortedArrayTests
{
    [TestFixture]
    public class FindingTargetValueTests
    {
        [Test]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 8, 10, 11, 12, 14 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 10, 11, 12, 14, 15, 16, 17, 18, 19 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10}, ExpectedResult = true)]
        [TestCase(10, new int[] { 11, 12, 14, 15, 16, 17, 18, 19 }, ExpectedResult = false)]
        public bool FindTargetValueInArrayTest(int target, int[] arrayOfValues)
        {
            FindingTargetValue targetValue = new FindingTargetValue();
            return targetValue.FindTargetValueInArray(target, arrayOfValues);
        }

        [Test]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 8, 10, 11, 12, 14 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 10, 11, 12, 14, 15, 16, 17, 18, 19 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 11, 12, 14, 15, 16, 17, 18, 19 }, ExpectedResult = false)]
        public bool OptimizedFindTargetValueInArrayTest(int target, int[] arrayOfValues)
        {
            FindingTargetValue targetValue = new FindingTargetValue();
            return targetValue.OptimizedFindTargetValueInArray(target, arrayOfValues);
        }

        [Test]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 8, 10, 11, 12, 14 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 1, 5, 6, 7, 8, 9, 10, 11, 12, 14 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 11, 12, 14, 15, 16, 17, 18, 19 }, ExpectedResult = false) ]
        public bool FindTargetSumInArrayTest(int target, int[] arrayOfValues)
        {
            FindingTargetValue targetValue = new FindingTargetValue();
            return targetValue.FindTargetSumInArray(target, arrayOfValues);
        }

        [Test]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 8, 10, 11, 12, 14 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 1, 5, 6, 7, 8, 9, 10, 11, 12, 14 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = true)]
        [TestCase(10, new int[] { 11, 12, 14, 15, 16, 17, 18, 19 }, ExpectedResult = false)]
        public bool OptimizedFindTargetSumInArrayTest(int target, int[] arrayOfValues)
        {
            FindingTargetValue targetValue = new FindingTargetValue();
            return targetValue.FindTargetSumInArray(target, arrayOfValues);
        }
    }
}
