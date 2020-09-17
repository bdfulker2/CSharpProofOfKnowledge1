using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class ProgrammingForLoops
    {
        public int DoWhileLoop()
        {
            var sum = 0;
            var counter = 0;
            do
            {
                sum += counter;
            } while (counter < 100);
            return sum;
        }
        
        public int WhileLoop()
        {
            var sum = 0;
            var counter = 0;
            while(counter < 100)
            {
                sum += counter;
            }
            return sum;
        }
        public int ForEachLoop()
        {
            List<int> numbers = new List<int>() { 1, 3, 5, 7, 9 };
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public int ForLoop()
        {
            var sum = 0;
            for(int i = 0; i < 100; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
