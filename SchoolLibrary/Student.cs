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
        /// <summary>
        /// Enumeration for GradeLevels
        /// </summary>
        public enum GradeLevels { Freshman, Sophmore, Junior, Senior }

        /// <summary>
        /// Property for accessing GradeLevel
        /// </summary>
        public GradeLevels GradLevels { get; set; }

        /// <summary>
        /// Overridden ComputGradeAverage method from abstract GradeAverage
        /// method in Person.cs class required in all classes that inherit
        /// from Person.cs
        /// </summary>
        /// <returns></returns>
        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        /// <summary>
        /// overridden virtual method SendMessage method not required unless
        /// code modifies the code block. But is not required like an
        /// abstract method
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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
