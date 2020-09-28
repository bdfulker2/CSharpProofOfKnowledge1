using System;

namespace FindingTargetValueInSortedArray
{
    public class FindingTargetValue
    {
        /// <summary>
        /// This is for finding a value in a sorted array where time constraints are
        /// not of importance. Will be in n time
        /// </summary>
        /// <param name="target"></param>
        /// <param name="arrayOfValues"></param>
        /// <returns></returns>
        public bool FindTargetValueInArray(int target, int[] arrayOfValues)
        {
            for(int i = 0; i < arrayOfValues.Length; i++)
            {
                if (arrayOfValues[i] == target) return true;
            }
            return false;
        }
    }
}
