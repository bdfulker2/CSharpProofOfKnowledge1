using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public static class ScoreUtility
    {
        public static IScored BestOfTwo(IScored assignment1, IScored assignment2)
        {
            var score1 = assignment1.Score / assignment1.MaximumScore;
            var score2 = assignment2.Score / assignment2.MaximumScore;

            if(score1 > score2)
            {
                return assignment1;
            }else
            {
                return assignment2;
            }
        }
    }
}
