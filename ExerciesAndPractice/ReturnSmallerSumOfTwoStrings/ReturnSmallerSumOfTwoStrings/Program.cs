using System;
using System.ComponentModel.DataAnnotations;

namespace ReturnSmallerSumOfTwoStrings
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //    SmallerNum("5", "5");
            SmallerStringNumNoIntParsed("5", "15");
            SmallerStringNumNoIntParsed("15", "5");
            SmallerStringNumNoIntParsed("1500", "1");
            SmallerStringNumNoIntParsed("5000", "1");
            SmallerStringNumNoIntParsed("00005", "1");
            SmallerStringNumNoIntParsed("00001", "23");
            SmallerStringNumNoIntParsed("1", "00001");
        }
        public static string SmallerNum(string n1, string n2)
        {
            var n1Parsed = int.TryParse(n1, out int n1Result);
            var n2Parsed = int.TryParse(n2, out int n2Result);
            if (n1Parsed && n2Parsed)
            {
                if (n2Result > n1Result) return n1;
                return n2;
            }
            return "0";
        }

        public static string SmallerStringNumNoIntParsed(string n1, string n2)
        {
            //Removes leading zero
            var newN1 = n1.TrimStart('0');
            //Console.WriteLine(n1 + ": " + newN1);
            var newN2 = n2.TrimStart('0');

            //Compares length
            if (newN1.Length < newN2.Length)
            {
                //returns n1 if trimmed comparison has smalled number of digits
                return n1;
            }
            else if (newN1.Length == newN2.Length)
            {
                for (int i = 0; i < newN1.Length; i++)
                {
                    var indexResult = String.CompareOrdinal(newN1, i, newN2, i, n1.Length);
                    if (indexResult < 0) return n1;
                    else if (indexResult == 0) continue;
                    else return n2;
                }
            }
            else
            {
                return n2;
            }
            if (n1.Length < n2.Length) return n1;

            return n2;
        }
    }
}
