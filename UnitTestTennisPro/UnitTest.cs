using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplocationCore.Entities;
using ApplocationCore.Entities.Match;
using ApplocationCore.Utilities;

namespace UnitTestTennisPro
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGamePlayScore0Increment()
        {
            // arrange
            var game = new TennisGame();
            var randomize0Winner = Utilities.getRandomInt(0, 0);

            // act
            game.playPoint(randomize0Winner);

            // assert
            Assert.IsTrue(game.PlayersPoints[0] == 1);
            Assert.IsTrue(game.PlayersPoints[1] == 0);
        }

        [TestMethod]
        public void TestGamePlayScore1Increment()
        {
            // arrange
            var game = new TennisGame();
            var randomize0Winner = Utilities.getRandomInt(1, 1);

            // act
            game.playPoint(randomize0Winner);

            // assert
            Assert.IsTrue(game.PlayersPoints[0] == 0);
            Assert.IsTrue(game.PlayersPoints[1] == 1);
        }

        [TestMethod]
        public void TestGamePlayer1WonBy4Points()
        {
            // arrange
            var game = new TennisGame();
            var randomize0Winner = Utilities.getRandomInt(0, 1);
            var randomize1Winner = Utilities.getRandomInt(1, 2);

            // act
            game.playPoint(randomize0Winner);
            game.playPoint(randomize0Winner);
            game.playPoint(randomize0Winner);
            game.playPoint(randomize0Winner);
          
            // assert
            Assert.IsTrue(game.hasWinner() == true);
            Assert.IsTrue(game.getWinner() == 0);
        }


        [TestMethod]
        public void TestGamePlayer1WonBy2Margin()
        {
            // arrange
            var game = new TennisGame();
            var randomize0Winner = Utilities.getRandomInt(0, 0);
            var randomize1Winner = Utilities.getRandomInt(1, 1);

            // act
            game.playPoint(randomize0Winner);
            game.playPoint(randomize1Winner);
            game.playPoint(randomize0Winner);
            game.playPoint(randomize1Winner);
            game.playPoint(randomize0Winner);
            game.playPoint(randomize1Winner);
            game.playPoint(randomize0Winner);
            game.playPoint(randomize1Winner);

            game.playPoint(randomize0Winner);
            game.playPoint(randomize0Winner);

            // assert
            Assert.IsTrue(game.hasWinner() == true);
            Assert.IsTrue(game.getWinner() == 0);
        }

        //TODO Add Unit tests for Player, Set and Match...
    }
}
