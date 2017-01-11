using System;
using CodeKatas.BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.BowlingGame
{
    [TestClass()]
    public class BowlingGameTests
    {
        [TestMethod()]
        public void TestGutterGameTest()
        {
            var bowlingGame = SetUpCame();

            RollPins(bowlingGame,20,0);
            Assert.AreEqual(0, bowlingGame.Score);
        }

        
        [TestMethod()]
        public void TestHIttingOnePinPerRollTest()
        {
            var bowlingGame = new Game();

            RollPins(bowlingGame, 20, 1);
            Assert.AreEqual(20, bowlingGame.Score);
        }

        [TestMethod()]
        public void TestOneSpareTest()
        {
            var bowlingGame = new Game();

            RollSpare(bowlingGame);
            bowlingGame.Roll(3);

            RollPins(bowlingGame, 17, 0);
            Assert.AreEqual(16, bowlingGame.Score);
        }
        [TestMethod()]
        public void TestOneStrikeTest()
        {
            var bowlingGame = new Game();

            RollStrike(bowlingGame);
            bowlingGame.Roll(3);
            bowlingGame.Roll(4);
            RollPins(bowlingGame, 16, 0);
            Assert.AreEqual(24, bowlingGame.Score);
        }

        [TestMethod()]
        public void TestPerfectGameTest()
        {
            var bowlingGame = new Game();

            RollPins(bowlingGame, 12, 10);
            Assert.AreEqual(300, bowlingGame.Score);
        }

        private static void RollSpare(Game bowlingGame)
        {
            bowlingGame.Roll(5);
            bowlingGame.Roll(5);
        }

        private static void RollStrike(Game bowlingGame)
        {
            bowlingGame.Roll(10);
        }


        private static Game SetUpCame()
        {
            return new Game();
        }

        private static void RollPins(Game bowlingGame, int numberOfRolls, int pinsHitPerRoll)
        {
            for (int i = 0; i < numberOfRolls; i++)
            {
                bowlingGame.Roll(pinsHitPerRoll);
            }
        }
    }


}