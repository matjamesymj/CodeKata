using CodeKatas.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.Numbers
{
    [TestClass()]
    public class DartboardDartScoreTests
    {
        [TestMethod()]
        public void ThrowDartTest()
        {
            var dartboardDartScore = new DartboardDartScore();

            dartboardDartScore.ThrowDart();
            var dartNumberHit = dartboardDartScore.NumberScore;
            Assert.AreEqual(dartNumberHit*2, dartboardDartScore.Double);
            Assert.AreEqual(dartNumberHit*3, dartboardDartScore.Trebble);
            
        }
    }
}