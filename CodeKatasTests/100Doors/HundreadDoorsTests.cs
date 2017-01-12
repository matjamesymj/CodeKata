using System;
using CodeKatas._100Doors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests._100Doors
{
    [TestClass()]
    public class HundreadDoorsTests
    {
        [TestMethod()]
        public void RunTest()
        {
            var hundreadDoors = new HundreadDoors();

          Assert.AreEqual("1, 4, 9, 16, 25, 36, 49, 64, 81, 100",  hundreadDoors.Run());
            
        }
    }
}