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
            int j = arrayOfValues.Length - 1;
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

        /// <summary>
        /// Checks the array for two values that sum to a specified target value
        /// There is no optimization in this method O=n^2
        /// </summary>
        /// <param name="target"></param>
        /// <param name="arrayOfValues"></param>
        /// <returns></returns>
        public bool FindTargetSumInArray(int target, int[] arrayOfValues)
        {
            int sum = 0;
            for (int i = 0; i < arrayOfValues.Length; i++)
            {
                for (int j = 0; j < arrayOfValues.Length; j++)
                {
                    if (arrayOfValues[i] + arrayOfValues[j] == target) return true;
                }
            }
            return false;
        }
         
        public bool OptimizedFindTargetSumInArray(int target, int[] arrayOfValues)
        {
            if (arrayOfValues != null) 
            {
                int i = 0, j = arrayOfValues.Length - 1;
                while(i <= arrayOfValues.Length / 2 +1)
                {
                    if (arrayOfValues[i] + arrayOfValues[j] < target) i++;
                    if (arrayOfValues[i] + arrayOfValues[j] > target) j--;
                    if (arrayOfValues[i] + arrayOfValues[j] == target) return true;
                    if (i == j) return false;
                }
            }
            return false;
        }
    }
}
