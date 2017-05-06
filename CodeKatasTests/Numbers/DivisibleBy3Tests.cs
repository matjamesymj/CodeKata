using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.Numbers;

namespace CodeKatasTests.Numbers
{
    [TestClass()]
    public class DivisibleBy3Tests
    {
        [TestMethod()]
        public void CountNumbersDivisibleBy3Test()
        {
            var divisibleBy3 = new DivisibleBy3();

           Assert.AreEqual(3,divisibleBy3.CountNumbersDivisibleBy3(9));
           Assert.AreEqual(4, divisibleBy3.CountNumbersDivisibleBy3(12));
           Assert.AreEqual(33, divisibleBy3.CountNumbersDivisibleBy3(100));


        }
    }
}