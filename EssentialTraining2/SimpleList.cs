using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class SimpleList
    {
        public List<string> Sauces { get; set; }
        public SimpleList()
        {
            Sauces = new List<string>();
        }
        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }
    }
}
