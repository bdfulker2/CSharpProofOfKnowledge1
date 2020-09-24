using System;

namespace ReturnSmallerSumOfTwoStrings
{
    public static class Program
    {
        static void Main(string[] args)
        {
        //    SmallerNum("5", "5");
        }
        public static string SmallerNum(string n1, string n2)
        {
            int n1Result = 0, n2Result = 0;
            var n1Parsed = int.TryParse(n1, out n1Result);
            var n2Parsed = int.TryParse(n2, out n2Result);
            if(n1Parsed && n2Parsed)
            { 
                if (n2Result > n1Result)
                {
                    //Console.WriteLine(n1Result);
                    return n1;
                }
                else
                {
                    //Console.WriteLine(n1Result);
                    //Console.WriteLine(n2Result);
                    return n2;
                }
            }
            else
            {
                //Console.WriteLine("You didn't value wasn't able to be parsed to an integer");
                return "0";
            }
            // n1;
        }
    }
}
