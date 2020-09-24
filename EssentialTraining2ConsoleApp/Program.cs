using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace EssentialTraining2ConsoleApp
{
    public class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The progarm started");
            Program program = new Program();
            program.Words = new List<string>
            {
                "milk",
                "bread",
                "cheese"
            };
            CrazyMathProblem();
            ReadTextFile();
        }
        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }   
            }catch (DirectoryNotFoundException e)
            {
                logger.Error("The directory was not found : " + e.Message);
                Console.WriteLine("Could not find the directory");
            }catch (FileNotFoundException e)
            {
                logger.Error("The file wasn't found : "+ e.Message);
                Console.WriteLine("Could not find the file");
            }catch(Exception e)
            {
                logger.Error("Unknown exception : "+ e.Message);
                Console.WriteLine("An unknown exception occurred with the following message : " + e.Message);
            }
            finally
            {
                Console.WriteLine("This finally runs all the time");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = income /= i;
            }
            return income;
        }
    }
}
 