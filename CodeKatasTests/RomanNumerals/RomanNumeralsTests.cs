using System;
using CodeKatas.RomanNumerals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.RomanNumerals
{
    [TestClass()]
    public class RomanNumeralsTests
    {
        [TestMethod()]
        public void TestReturnValuesFor1to3Passed()
        {
            Assert.AreEqual("I", RomanNumeralsUtils.ArabicToRoman(1));
            Assert.AreEqual("II", RomanNumeralsUtils.ArabicToRoman(2));
            Assert.AreEqual("III", RomanNumeralsUtils.ArabicToRoman(3));
        }

        [TestMethod]
        public void TestReturnValue4()
        {
            Assert.AreEqual("IV", RomanNumeralsUtils.ArabicToRoman(4));
        }
        [TestMethod]
        public void TestReturnValue5()
        {
            Assert.AreEqual("V", RomanNumeralsUtils.ArabicToRoman(5));
        }

        [TestMethod]
        public void TestReturnValue6To8()
        {
            Assert.AreEqual("VI", RomanNumeralsUtils.ArabicToRoman(6));
            Assert.AreEqual("VII", RomanNumeralsUtils.ArabicToRoman(7));
            Assert.AreEqual("VIII", RomanNumeralsUtils.ArabicToRoman(8));
        }

        [TestMethod]
        public void TestReturnValue10()
        {
            Assert.AreEqual("X", RomanNumeralsUtils.ArabicToRoman(10));
        }

        [TestMethod]
        public void TestReturnValue11()
        {
            Assert.AreEqual("XI", RomanNumeralsUtils.ArabicToRoman(11));
        }
        [TestMethod]
        public void TestReturnValue19()
        {
            Assert.AreEqual("XIX", RomanNumeralsUtils.ArabicToRoman(19));
        }
        [TestMethod]
        public void TestReturnValue50()
        {
            Assert.AreEqual("L", RomanNumeralsUtils.ArabicToRoman(50));
        }

        [TestMethod]
        public void TestReturnValue40()
        {
            Assert.AreEqual("XL", RomanNumeralsUtils.ArabicToRoman(40));
        }

        [TestMethod]
        public void TestReturnValue927()
        {
            Assert.AreEqual("CMXXVII", RomanNumeralsUtils.ArabicToRoman(927));
        }

        [TestMethod]
        public void TestReturnValue3000()
        {
            Assert.AreEqual("MMM", RomanNumeralsUtils.ArabicToRoman(3000));
        }


    }
}