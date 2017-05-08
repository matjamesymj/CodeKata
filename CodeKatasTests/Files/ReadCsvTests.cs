using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.Files;

namespace CodeKatasTests.Files
{
    [TestClass()]
    public class ReadCsvTests
    {
        [TestMethod()]
        public void ReadCsvFileTest()
        {
            var readCsv = new ReadCsv();
            readCsv.ReadCsvFile();
            //3 rows in test file
            Assert.AreEqual(3, readCsv.ReadCsvFile().Count);
        }
    }
}