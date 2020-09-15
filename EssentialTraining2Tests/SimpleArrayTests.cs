using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTraining2Tests
{
    [TestClass]
    public class SimpleArrayTests
    {
        
       
        [TestMethod]
        public void SimpleArrayTest()
        {
            var testSimpleArrayInstance = new SimpleArray();
            Assert.AreEqual(4, testSimpleArrayInstance.GroceryList.Length);
            Assert.AreEqual("Milk", testSimpleArrayInstance.GroceryList[1].ToString());
        }
        [TestMethod]
        public void TestToString()
        {
            var testSimpleArrayInstance = new SimpleArray();
            Assert.IsTrue(testSimpleArrayInstance.ToString().StartsWith("There are"));
        }
    }
}
