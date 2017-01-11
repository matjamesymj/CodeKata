using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.OddEven
{
    [TestClass()]
    public class OddEvenTests
    {
        [TestMethod()]
        public void PrintTest1To11()
        {
            var oddEven = new CodeKatas.OddEven.OddEven();

            var result = oddEven.Print(1,11);
          
            Assert.AreEqual("Odd Even 3 Even 5 Even 7 Even Odd Even", result);

        }

        [TestMethod()]
        public void PrintTest11To1()
        {
            var oddEven = new CodeKatas.OddEven.OddEven();

            var result = oddEven.Print(11, 1);

            Assert.AreEqual("", result);

        }
    }
}