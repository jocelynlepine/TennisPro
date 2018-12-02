using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Entities.Match
{
    public class TennisSet : BaseEntity
    {
        public List<TennisGame> TennisGames { get; set; }

        public TennisSet()
        {
            TennisGames = new List<TennisGame>();
        }

        public bool hasWinner()
        {
            //A player wins a set if they have won at least 6 games by a margin of 2 or more.
            var minGamesToWin = 6;
            var gamesMargin = 2;
            var player0WonGames = TennisGames.FindAll(game => game.hasWinner() && game.getWinner() == 0);
            var player1WonGames = TennisGames.FindAll(game => game.hasWinner() && game.getWinner() == 1);
            return ((player0WonGames.Count >= minGamesToWin || player1WonGames.Count >= minGamesToWin) &&
                     Math.Abs(player0WonGames.Count - player1WonGames.Count) >= gamesMargin);
        }

        public int getWinner()
        {
            var winnerId = -1;
            if (hasWinner())
            {
                var player0WonGames = TennisGames.FindAll(game => game.hasWinner() && game.getWinner() == 0);
                var player1WonGames = TennisGames.FindAll(game => game.hasWinner() && game.getWinner() == 1);
                winnerId = (player0WonGames.Count > player1WonGames.Count) ? 0 : 1;
            }
            return winnerId;
        }

        public int getWinningGamesCount(int playerId)
        {
            return TennisGames.FindAll(game => game.hasWinner() && game.getWinner() == playerId).Count;
        }

        public void playSet()
        {
            //Sets should be played until there is a winner – there should not be any tie breaks
            var gameId = 0;
            TennisGames.Add(new TennisGame());
            while (!hasWinner()) {
                while (!TennisGames[gameId].hasWinner())
                {
                    TennisGames[gameId].playPoint(Utilities.Utilities.getRandomInt(0, 2));
                }
                if (hasWinner())
                {
                    continue;
                }
                gameId++;
                TennisGames.Add(new TennisGame());
            }
;        }
    }
}
