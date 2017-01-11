using System;
using System.Runtime.Remoting.Messaging;
using CodeKatas.TennisKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.TennisKata
{
    [TestClass()]
    public class TennisGameTests
    {
        [TestMethod()]
        public void ScoreShouldBeLoveAllTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            Assert.AreEqual("Love-All", tennisGame.Score());
        }
        [TestMethod()]
        public void ScoreShouldBeFifteenTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");

            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
            Assert.AreEqual("Fifteen-All", tennisGame.Score());
        }
        [TestMethod()]
        public void ScoreShouldBeFifteenLoveTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            Assert.AreEqual("Fifteen-Love", tennisGame.Score());
        }
        [TestMethod()]
        public void ScoreShouldBeFifteenThiryTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            Assert.AreEqual("Fifteen-Thirty", tennisGame.Score());
        }
        [TestMethod()]
        public void ScoreShouldBeThiryFifteenTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
            Assert.AreEqual("Thirty-Fifteen", tennisGame.Score());
        }

        [TestMethod()]
        public void ScoreShouldBeAdvantagePlayer1Test()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");

            Assert.AreEqual("Advantage - James", tennisGame.Score());
        }
        [TestMethod()]
        public void ScoreShouldBeAdvantagePlayer2Test()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");

            Assert.AreEqual("Advantage - Edwards", tennisGame.Score());
        }

        [TestMethod()]

        public void ScoreShouldbePlayer1WonTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
       

            Assert.AreEqual("James - Won", tennisGame.Score());
        }

        [TestMethod()]
        public void ScoreShouldbePlayer2WonTest()
        {

            TennisGame tennisGame = new TennisGame("James", "Edwards");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("James");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");
            tennisGame.PointScored("Edwards");

            Assert.AreEqual("Edwards - Won", tennisGame.Score());
        }
    }
}