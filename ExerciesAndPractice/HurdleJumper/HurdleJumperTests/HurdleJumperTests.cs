using System;
using NUnit.Framework;
using HurdleJumpers;

namespace HurdleJumpersTests
{
    [TestFixture]
    public class HurdleJumperTests
    {
        [Test]
        public bool HurdleJumpTest(int[] hurdleHeights, int jumpersJumpHeight)
        {
            HurdleJumper hurdle = new HurdleJumper();
            return hurdle.HurdleJump(hurdleHeights, jumpersJumpHeight);
        }
    }
}
