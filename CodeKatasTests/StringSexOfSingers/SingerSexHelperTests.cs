using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.StringSexOfSingers;

namespace CodeKatasTests.StringSexOfSingers

{
    [TestClass()]
    public class SingerSexHelperTests
    {
        [TestMethod()]
        public void CountMaleSingersTest()
        {
            SingerSexHelper singerSexHelper = new SingerSexHelper();

           var singers = new string[6];
           
            singers[0] = "Beyonce (f)";
            singers[1] = "David Bowie (m)";
            singers[2] = "Elvis Costello (m)";
            singers[3] = "Madonna(f)";
            singers[4] = "Elton John (m)";
            singers[5] = "Charles Aznavour (m)";

            var numberOfMales = singerSexHelper.CountSingersForSex(singers, Sex.Male);
            Assert.AreEqual(4,numberOfMales);
        }

        [TestMethod()]
        public void CountFemaleSingersTest()
        {
            SingerSexHelper singerSexHelper = new SingerSexHelper();

            var singers = new string[6];

            singers[0] = "Beyonce (f)";
            singers[1] = "David Bowie (m)";
            singers[2] = "Elvis Costello (m)";
            singers[3] = "Madonna(f)";
            singers[4] = "Elton John (m)";
            singers[5] = "Charles Aznavour (m)";

            var numberOfMales = singerSexHelper.CountSingersForSex(singers, Sex.Female);
            Assert.AreEqual(2, numberOfMales);
        }
    }
}