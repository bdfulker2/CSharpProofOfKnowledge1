using System;

namespace CSharpConsoleApp
{
    class Program
    {
        //String field/property named title. Static keyword used in instances where the value is static and doesn't change and will not change/constant
        private static string title = "Welcome to my C# Console Application";

        //Enclosing a static member in a structure will allow you to access the property without instantiating the class.
        public struct structureToAllowNonStaticAccessToStaticField
        {
            public static int whichVersion;
        }

        static void Main(string[] args)
        {
            //Allows for assignment of static variable by access the strut instead of class instantiation.
            //This also allow for access from outside of current scope. But fully qualified name 
            //"Progam.structureToAllowNonStaticAccessToStaticField.whichPart" would be needed
            structureToAllowNonStaticAccessToStaticField.whichVersion = 2;
            
            //manually formated output
            Console.WriteLine("Hello. "+  title + " "+ structureToAllowNonStaticAccessToStaticField.whichVersion); //output of static variable
           
             
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
