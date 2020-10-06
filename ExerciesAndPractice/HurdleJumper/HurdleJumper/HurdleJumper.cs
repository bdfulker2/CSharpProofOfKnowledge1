using System;

namespace HurdleJumpers
{
    public class HurdleJumper
    {
        public bool HurdleJump(int[] hurdleHeights, int jumpersJumpHeight)
        {
            if (hurdleHeights.Length == 0) return true;
            for(int i = 0; i < hurdleHeights.Length; i++)
            {
                if (hurdleHeights[i] > jumpersJumpHeight) return false;
            }
            return true;
        }
    }
}
