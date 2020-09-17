using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    /// <summary>
    /// This class shows examples of different Flow Control conditional statements
    /// </summary>
    public class FlowControl
    {
        public string PrimaryOrSecondary(string color)
        {
            var result = "";
            if (string.Equals(color, "red", StringComparison.OrdinalIgnoreCase))
            {
                result = "Primary";
            }
            else if (string.Equals(color, "blue", StringComparison.OrdinalIgnoreCase))
            {
                result = "Primary";
            }
            else if (string.Equals(color, "Yellow", StringComparison.OrdinalIgnoreCase))
            {
                result = "Primary";
            }else
            {
                result = "Secondary";
            }
            return result;
        }
        /// <summary>
        /// Flow Control using string.Equals for a string comparison
        /// </summary>
        /// <param name="color"></param>
        /// <returns>returns boolean result of string comparison</returns>
        public bool IsYourFavoriteColorBlue(string color)
        {
            /***
             * Returns true if two strings match and false if they don't.
             */
            return string.Equals(color, "blue", StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Flow control with regular old fashioned if else statements
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public bool IsYourFavoriteColorRed(string color)
        {
            /***
            * Examples of how flow control method above can be written.
            */
           if(color.ToLower() == "red")
           {
                return true;
           }else
           {
                return false;
           }
        }

        /// <summary>
        /// Flow control with return statement
        /// </summary>
        /// <param name="color">string for receiving color</param>
        /// <returns>bool result of input</returns>
        public bool IsYourFavoriteColorGreen(string color)
        {
            /***
            * Examples of how flow control method above can be written.
            */
            return color.ToLower() == "green";
        }

        /// <summary>
        /// Flow control with only if statement
        /// </summary>
        /// <param name="color">string param for passing in color</param>
        /// <returns>boolean value</returns>
        public bool IsYourFavoriteColorYellow(string color)
        {
            /***
            * Examples of how flow control method above can be written.
            */
            if (color.ToLower() == "yellow") return true;
            
            return false; 
        }

        /// <summary>
        /// Example using ternary Operator
        /// </summary>
        /// <param name="color">string input of color</param>
        /// <returns>bool result of input</returns>
        public bool IsYouFavoriteColorBlack(string color)
        {
            return (color.ToLower() == "black") ? true : false;
        }
    }
}
