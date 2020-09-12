using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        /// <summary>
        /// Property for accessing Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property for accessing Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Property for Accessing City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Property for accessing State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Property for accessing Zip
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Property for accessing PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }

        //backing variable for TwitterAddress Property
        private string _twitterAddress;

        /// <summary>
        /// Non automatic Property for accessing TwitterAddress
        /// </summary>
        public string TwitterAddress
        {
            //make sure address starts with @ symbol
            get { return _twitterAddress; }
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

        /// <summary>
        /// Constructor with no parameters
        /// </summary>
        public School()
        {
            Name = "Untitled School";
            Address = "1234 fake address";
            City = "Fake City";
            State = "FL";
            Zip = "55555";
            TwitterAddress = "@faketwitteraddress";
            PhoneNumber = "555-1234";
        }

        /// <summary>
        /// Constructor with parameters to pass in all properties associated with a school
        /// </summary>
        /// <param name="schoolName">used to set Name property</param>
        /// <param name="schoolAddress">used to set Address property</param>
        /// <param name="schoolCity">used to set City property</param>
        /// <param name="schoolState">used to set State property</param>
        /// <param name="schoolZip">used to set Zip property</param>
        /// <param name="schoolTwitterAddress">used to set TwitterAddress</param>
        /// <param name="schoolPhoneNumber">used to set PhoneNumber property</param>
        public School(string schoolName, string schoolAddress, string schoolCity, string schoolState, string schoolZip, string schoolTwitterAddress, string schoolPhoneNumber)
        {
            Name = schoolName;
            Address = schoolAddress;
            City = schoolCity;
            State = schoolState;
            Zip = schoolZip;
            TwitterAddress = schoolTwitterAddress;
            PhoneNumber = schoolPhoneNumber;
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
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

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
        public static int AverageThreeScores(int a, int b, int c) => (a + b + c) / 3;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
            return sb.ToString();
        }
    }
}
