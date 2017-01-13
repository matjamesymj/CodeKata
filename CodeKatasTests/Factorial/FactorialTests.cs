using System;
using CodeKatas.Factorial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.Factorial
{
    [TestClass()]
    public class FactorialTests
    {
        [TestMethod()]
        public void CalculateFactorialOfZero()
        {
           FactorialCalcualator factorialCalcualator = new FactorialCalcualator();

           Assert.AreEqual(1,factorialCalcualator.CalculateUsingForLoop(0));
        }
        [TestMethod()]
        public void CalculateFactorialOfFour()
        {
            FactorialCalcualator factorialCalcualator = new FactorialCalcualator();

            Assert.AreEqual(24, factorialCalcualator.CalculateUsingForLoop(4));
        }

        [TestMethod()]
        public void CalculateFactorialUsingRecursionForZero()
        {
            FactorialCalcualator factorialCalcualator = new FactorialCalcualator();
            Assert.AreEqual(1, factorialCalcualator.CalculateUsingRecursion(0));
        }
        [TestMethod()]
        public void CalculateFactorialUsingRecursionForFour()
        {
            FactorialCalcualator factorialCalcualator = new FactorialCalcualator();
            Assert.AreEqual(24, factorialCalcualator.CalculateUsingRecursion(4));
        }
    }
}