using System;
using System.Collections.Generic;

namespace EssentialTraining2ConsoleApp
{
    public class Program
    {
        public List<string> Words;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Words = new List<string>
            {
                "milk",
                "bread",
                "cheese"
            };
        }
    }
}
