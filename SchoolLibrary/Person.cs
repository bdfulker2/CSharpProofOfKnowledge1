using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    /// <summary>
    /// Abstract Class that can't be instantiated. Base class for
    /// Student and Teacher classes
    /// </summary>
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
