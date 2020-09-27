using System;

namespace ArrayOfMultiples
{
    /// <summary>
    /// Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
    /// </summary>
    public class ArrayOfMultiples
    {
        public int[] ArrayOfMulitples(int num, int length)
        {
            int[] multiple = new int[length];
            for(int i = 0; i < length; i++)
            {
                multiple[i] = (i + 1) * num;
            }
            return multiple;
        }
    }
}
