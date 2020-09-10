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
        public override string SendMessage(string message)
        {
            var sb = new StringBuilder(base.SendMessage(message));
            sb.AppendLine("Disclaimer: Due to Florida' broad open records law, most written " +
                "communications to or from College employees are public record, available to the" +
                " public and the media upon request. Therefore, this email communication may be " +
                "subject to public disclosure."
            );
            return sb.ToString();
        }
    }
}
