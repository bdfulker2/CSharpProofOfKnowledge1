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
            for (int i = 0; i < arrayOfValues.Length; i++)
            {
                if (arrayOfValues[i] == target) return true;
            }
            return false;
        }

        /// <summary>
        /// Optimized by iterating in both directions until value is found.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="arrayOfValues"></param>
        /// <returns></returns>
        public bool OptimizedFindTargetValueInArray(int target, int[] arrayOfValues)
        {
            int i = 0;
            int j = arrayOfValues.Length -1;
            while (i < arrayOfValues.Length)
            {
                if (arrayOfValues[i] == target) return true;
                else i++;
                if (arrayOfValues[j] == target) return true;
                else j--;
                if (i == j) return false;
            }
            return false;
        }
    }
}
