using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTraining2Tests
{
    [TestClass]
    public class AddTwoIntegersTests
    {
        [TestMethod]
        public void AddTwoIntersTest()
        {
            var testInstnace = new AddTwoIntegers();
            var testResult = testInstnace.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "I expect 9 + 5 = 14");
        }
    }
}
