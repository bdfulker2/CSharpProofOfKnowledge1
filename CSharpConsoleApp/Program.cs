using System;

namespace CSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my C# Console Application");
           
            Console.WriteLine("Press Enter to continue");

            /****
            * Introduces the .ReadLine to pause application. This is done to 
            * allow user to actually see the output as it would just print output
            * and user would likely not be able to read it due to speed.
            */
            Console.ReadLine();
        }
    }
}
