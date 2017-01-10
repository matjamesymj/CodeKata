using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.TwoSum
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void FindTwoSumTestIndexValues1And4()
        {
            var expected = new Tuple<int,int>(1, 4);
            Assert.AreEqual(expected,CodeKatas.TwoSum.TwoSum.FindTwoSum(list: new List<int> { 1, 3, 5, 7, 9 }, sum: 12));
            
        }

        [TestMethod()]
        public void FindTwoSumTestShouldReturnNull()
        {
            
            Assert.AreEqual(null, CodeKatas.TwoSum.TwoSum.FindTwoSum(list: new List<int> { 1, 3, 5, 7, 9 }, sum: 3));

        }
    }
}