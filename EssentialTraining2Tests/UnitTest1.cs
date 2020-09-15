using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTraining2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstnace = new Class1();
            var testResult = testInstnace.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "I expect 9 + 5 = 14");
        }
    }
}
