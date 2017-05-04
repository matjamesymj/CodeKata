using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.StringCMajor;

namespace CodeKatasTests.StringCMajor
{
    [TestClass()]
    public class CMajorTests
    {
        [TestMethod()]
        public void ConverToCMajorTest()
        {
            var cMajor = new CMajor();
            Assert.AreEqual("CDEFGAB", cMajor.ConverToCMajor());
        }
    }
}