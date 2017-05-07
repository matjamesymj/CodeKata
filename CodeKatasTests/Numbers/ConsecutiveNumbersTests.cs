using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.Numbers;

namespace CodeKatasTests.Numbers
{
    [TestClass()]
    public class ConsecutiveNumbersTests
    {
        [TestMethod()]
        public void IsConsectiveNumbersReturnTrueTest()
        {

            var consecutiveNumbers = new ConsecutiveNumbers();
            Assert.IsTrue(consecutiveNumbers.IsConsectiveNumbers("10-9-8-7-6"));
            Assert.IsTrue(consecutiveNumbers.IsConsectiveNumbers("1-2-3-4-5"));


        }

        [TestMethod()]
        public void IsConsectiveNumbersReturnFalseTest()
        {

            var consecutiveNumbers = new ConsecutiveNumbers();
            Assert.IsFalse(consecutiveNumbers.IsConsectiveNumbers("10-9-7-6"));
            Assert.IsFalse(consecutiveNumbers.IsConsectiveNumbers("1-2-2-3-4-5"));


        }
    }
}