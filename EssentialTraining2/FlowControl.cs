using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorBlue(string color)
        {
            /***
             * Returns true if two strings match and false if they don't.
             */
            return string.Equals(color, "blue", StringComparison.CurrentCultureIgnoreCase);
            
            /***
             * Examples of how flow control method above can be written.
             * if(string.Equals(color, "blue", StringComparison.CurrentCultureIgnoreCase))
            * {
            *     return true;
            * }else
            * {
            *     return false;
            * }
            *
            * if(color.ToLower() == "blue")
            * {
            *     return true;
            * }else
            * {
            *     return false;
            * }
            */

        }
    }
}
