using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    /// <summary>
    /// Teacher class inherits from Person class to
    /// give access to properties FirstName, LastName and email.
    /// </summary>
    public class Teacher : Person
    {
        /// <summary>
        /// Property for accessing Subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Overridden method for calculating grade average.
        /// </summary>
        /// <returns></returns>
        public override float ComputeGradeAverage()
        {
            //TODO: fix implementation later
            return 0.0f;
        }
    }
}
