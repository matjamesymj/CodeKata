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
            Assert.AreEqual(consecutiveNumbers.IsConsectiveNumbers("10-9-8-7-6"),ConsecutiveResult.Yes);
            Assert.AreEqual(consecutiveNumbers.IsConsectiveNumbers("1-2-3-4-5"),ConsecutiveResult.Yes);
        }

        [TestMethod()]
        public void IsConsectiveNumbersReturnFalseTest()
        {

            var consecutiveNumbers = new ConsecutiveNumbers();
            Assert.AreEqual(consecutiveNumbers.IsConsectiveNumbers("10-9-7-6"),ConsecutiveResult.No);
            Assert.AreEqual(consecutiveNumbers.IsConsectiveNumbers("1-2-4-5-6"), ConsecutiveResult.No);
        }

        [TestMethod()]
        public void IsConsectiveNumbersReturnContainsPairTest()
        {

            var consecutiveNumbers = new ConsecutiveNumbers();
            Assert.AreEqual(consecutiveNumbers.IsConsectiveNumbers("1-2-2-3-4-5"), ConsecutiveResult.ContainsPair);

        }


    }
}