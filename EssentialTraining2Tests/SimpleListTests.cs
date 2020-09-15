using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTraining2Tests
{
    [TestClass]
    public class SimpleListTests
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testSimpleListInstance = new SimpleList();
            testSimpleListInstance.Sauces.Add("Tabasco");
            testSimpleListInstance.Sauces.Add("Siraccha");
            testSimpleListInstance.Sauces.Add("Trailer Trash");

            //Assert expect true
            Assert.IsTrue(testSimpleListInstance.IsSauceAwesome("Trailer Trash"));

            //Assert expect false
            Assert.IsFalse(testSimpleListInstance.IsSauceAwesome("A1"));
        }
    }
}
