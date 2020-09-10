using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophmore, Junior, Senior }
        public GradeLevels GradLevels { get; set; }

    }
}
