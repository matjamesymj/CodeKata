using System;
using CodeKatas.String_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.String_Calculator
{
    [TestClass()]
    public class StringCalculatorTests
    {
        [TestMethod()]
        public void AddTestReturnZeroForEmptyString()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(0,stringCalculator.Add(""));
        }

        [TestMethod()]
        public void AddTestReturnOneForSingleNumbeOf1Passed()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(1, stringCalculator.Add("1"));
        }

        [TestMethod()]
        public void AddTestReturnSumOf2NumbersWhenSeperatedByComma()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(3, stringCalculator.Add("1,2"));
        }

        [TestMethod()]
        public void AddTestReturnSumOfUnkownNumbersWhenSeperatedByComma()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(15, stringCalculator.Add("1,2,3,4,5"));
        }
        [TestMethod()]
        public void AddTestReturnSumOfNewlineSeperator()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(15, stringCalculator.Add("1\n2,3,4,5"));
        }
        [TestMethod()]
        public void AddTestReturnCorrectValueWhenStartingSeperatorLineIsPresent()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(3, stringCalculator.Add("//;\n1;2"));
        }
        [TestMethod(), ExpectedException(typeof(Exception))]
        public void AddTestThrowExceptionIfANumberILessThanZero()
        {
            var stringCalculator = new StringCalculator();
           stringCalculator.Add("1,-2");
        }

        [TestMethod()]
        public void AddTestIgnoreNumbersGreaterThanAThousand()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(2, stringCalculator.Add("1001,2"));
        }
    }
}