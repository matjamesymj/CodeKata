using System;
using CodeKatas.String_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CodeKatasTests.String_Calculator
{
    [TestClass()]
    public class StringCalculatorTests
    {
        private Mock<IConsole> _consoleMock;

        public StringCalculator StringCalculator
        {
            get { return new StringCalculator(_consoleMock.Object); }
        }


        [TestInitialize]
        public void TestInitialize()
        {
            _consoleMock = new Mock<IConsole>();
        }

        [TestMethod()]
        public void AddTestReturnZeroForEmptyString()
        {
            Assert.AreEqual(0, StringCalculator.Add(""));
        }

        [TestMethod()]
        public void AddTestReturnOneForSingleNumbeOf1Passed()
        {
            Assert.AreEqual(1, StringCalculator.Add("1"));
        }

        [TestMethod()]
        public void AddTestReturnSumOf2NumbersWhenSeperatedByComma()
        {
            Assert.AreEqual(3, StringCalculator.Add("1,2"));
        }

        [TestMethod()]
        public void AddTestReturnSumOfUnkownNumbersWhenSeperatedByComma()
        {
            Assert.AreEqual(15, StringCalculator.Add("1,2,3,4,5"));
        }
        [TestMethod()]
        public void AddTestReturnSumOfNewlineSeperator()
        {
            Assert.AreEqual(15, StringCalculator.Add("1\n2,3,4,5"));
        }
        [TestMethod()]
        public void AddTestReturnCorrectValueWhenStartingSeperatorLineIsPresent()
        {
            Assert.AreEqual(3, StringCalculator.Add("//;\n1;2"));
        }
        [TestMethod(), ExpectedException(typeof(Exception))]
        public void AddTestThrowExceptionIfANumberILessThanZero()
        {
            StringCalculator.Add("1,-2");
        }

        [TestMethod()]
        public void AddTestIgnoreNumbersGreaterThanAThousand()
        {
            Assert.AreEqual(2, StringCalculator.Add("1001,2"));
        }

        [TestMethod()]
        public void AddTestWhenSeperatorIs3Asterisks()
        {
            Assert.AreEqual(6, StringCalculator.Add("1***2***3"));
        }

        [TestMethod()]
        public void AddTestWhenSeperatorIs3DifferentTypes()
        {
            Assert.AreEqual(10, StringCalculator.Add("1,2;3***4"));
        }
        [TestMethod()]
        public void AddTestVerifyConsoleWasCalled()
        {


            var stringCalculator = new StringCalculator(_consoleMock.Object);

            Assert.AreEqual(10, stringCalculator.Add("1,2;3***4"));
            _consoleMock.Verify(console => console.WriteLine("The result is 10"));
        }
    }
}