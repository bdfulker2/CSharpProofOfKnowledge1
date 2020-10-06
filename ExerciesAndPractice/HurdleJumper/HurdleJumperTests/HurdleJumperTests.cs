using System;
using NUnit.Framework;
using HurdleJumpers;

namespace HurdleJumpersTests
{
    [TestFixture]
    public class HurdleJumperTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 5, 5, 3, 4, 5 }, 3, ExpectedResult = false)]
        [TestCase(new int[] { 5,4,5,6 }, 10, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 1 }, 1, ExpectedResult = false)]
        [TestCase(new int[] { }, 1, ExpectedResult = true)]
        public bool HurdleJumpTest(int[] hurdleHeights, int jumpersJumpHeight)
        {
            HurdleJumper hurdle = new HurdleJumper();
            return hurdle.HurdleJump(hurdleHeights, jumpersJumpHeight);
        }
    }
}
