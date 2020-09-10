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
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            //TODO: fix implementation later
            return 0.0f;
        }
    }
}
