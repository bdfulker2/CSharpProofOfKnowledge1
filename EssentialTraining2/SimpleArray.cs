using System;
using System.Collections.Generic;
using System.Linq;
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
            StringBuilder groceries = new StringBuilder();
            for(int i = 0; i < GroceryList.Length; i++)
            {
                groceries.Append(GroceryList[i]);
                if(i < GroceryList.Length-1)
                {
                    groceries.Append(", ");
                }
            }
            return "There are " + GroceryList.Length + " and they are " + groceries + ".";
        }
    }
}
