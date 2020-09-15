using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EssentialTraining2
{
    public class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }

        public override string ToString()
        {
            for(int i = 0; i < GroceryList.Length; i++)
            {
                
            }
            return "There are " + GroceryList.Length + "and they are " + GroceryList.ToString();
        }
    }
}
