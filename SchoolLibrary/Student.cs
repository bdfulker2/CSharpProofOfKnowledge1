using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    /// <summary>
    /// Student class inherits from Person class to
    /// give access to properties FirstName, LastName and email.
    /// </summary>
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophmore, Junior, Senior }
        public GradeLevels GradLevels { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
