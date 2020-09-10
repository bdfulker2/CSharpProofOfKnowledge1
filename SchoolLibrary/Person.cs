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
        /// <summary>
        /// Property for FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Property for LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Property for Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Abstract method for ComputeGradeAverage overridden
        /// method is required in all class that inherit from
        /// the person class.
        /// </summary>
        /// <returns></returns>
        public abstract float ComputeGradeAverage();

        /// <summary>
        /// Virtual method for SendMessage can be overridden in
        /// classes that inherit from Person class but are not required.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.Append("Dear ")
              .Append(FirstName)
              .AppendLine(",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
