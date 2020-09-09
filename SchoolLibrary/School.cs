using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        //backing variable for TwitterAddress Property
        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure address starts with @ symbol
            get { return _twitterAddress; };
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @.");
                }
            }

        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }


        /// <summary>
        /// Function bodied express representing below logic
        ///     public float AverageThreeScores(float a, float b, float c)
        ///     {
        ///         var result = (a + b + c) / 3;
        ///         return result;
        ///     }
        /// </summary>
        /// <param name="a">value 1 of average</param>
        /// <param name="b">value 2 of average</param>
        /// <param name="c">value 3 of average</param>
        /// <returns>returns float value of the a, b, and c parameters/arguments</returns>
        public float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        /// <summary>
        /// Function bodied Expression representing below logic
        ///     public int AverageThreeScores(int a, int b, int c)
        ///     {
        ///         var result = (a + b + c) / 3;
        ///         return result;
        ///     }
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>returns integer average of the a, b, and c parameters/arguments</returns>
        public int AverageThreeScores(int a, int b, int c) => (a + b + c) / 3;
        
    }
}
