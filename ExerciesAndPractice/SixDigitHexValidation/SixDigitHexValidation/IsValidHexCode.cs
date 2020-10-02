using System;
using System.Text.RegularExpressions;

namespace SixDigitHexValidation
{
    /// <summary>
    /// Exercies is to:
    /// Create a function that determines whether a string is a valid hex code.
    /// A hex code must begin with a pound key # and is exactly 6 characters in length.
    /// Each character must be a digit from 0-9 or an alphabetic character from A-F. 
    /// All alphabetic characters may be uppercase or lowercase.
    /// </summary>
    public class IsValidHexCode
    {
        private readonly Regex defaultRegex = new Regex(@"^[a-fA-F0-9]+$");
        /// <summary>
        /// Validates that we have six digit hex code base on set condition 
        /// </summary>
        /// <param name="hexValue">is a 7 digit string with example #45EFEF letter are [a-fA-F]</param>
        /// <returns>boolean value of whether paramater is HexCode based on definition</returns>
        public bool ValidateSixDigitHexCode(string hexValue)
        {
            if (!hexValue.StartsWith("#")) return false;
            string hexTemp = hexValue.TrimStart('#');
            return defaultRegex.IsMatch(hexTemp) && hexValue.Length == 7;
        }
    }
}
