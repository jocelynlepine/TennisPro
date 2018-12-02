using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Entities.Match
{
    public class TennisGame : BaseEntity
    {
        public List<int> PlayersPoints { get; set; }

        public TennisGame()
        {
            PlayersPoints = new List<int> { 0, 0 };
        }

        public void playPoint(int randomPlayerIdWinner)
        {
            if (randomPlayerIdWinner < 0 || randomPlayerIdWinner > PlayersPoints.Count-1) { 
                throw new  ArgumentException("Invalid randomPlayerIdWinner value");
            }
            PlayersPoints[randomPlayerIdWinner]++;
        }

        public bool hasWinner()
        {
            // as defined at https://en.wikipedia.org/wiki/Tennis_scoring_system
            // A game consists of a sequence of points played with the same player serving, 
            // and is won by the first side to have won at least four points with a margin of two points or more over their opponent.
            var minPointsToWin = 4;
            var pointsMargin = 2;
            return ((PlayersPoints[0] >= minPointsToWin || PlayersPoints[1] >= minPointsToWin) &&
                Math.Abs(PlayersPoints[0] - PlayersPoints[1]) >= pointsMargin);
        }

        public int getWinner()
        {
            var winnerId = -1;
            if (hasWinner())
            {
                winnerId = (PlayersPoints[0] > PlayersPoints[1]) ? 0 : 1;
            }
            return winnerId;
        }

    }
}
