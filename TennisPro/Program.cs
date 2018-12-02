using System;
using ApplocationCore.Entities;
using ApplocationCore.Entities.Match;

namespace TennisPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Orbis Tennis Pro!");

            Console.WriteLine("Please enter Player 1 name:");
            var player1Name = Console.ReadLine();

            Console.WriteLine("Please enter Player 2 name:");
            var player2Name = Console.ReadLine();

            var match = new TennisMatch(player1Name, player2Name);
            match.playMatch();
            Console.WriteLine("Match Results");
            Console.WriteLine($"        {player1Name} , {player2Name}");

            for (int set = 0; set < match.TennisSets.Count; set++)
            {
                Console.WriteLine($"Set: {set + 1}");
                foreach (var tennnisGame in  match.TennisSets[set].TennisGames) {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"    Game:");
                    Console.ForegroundColor = tennnisGame.getWinner() == 0 ? ConsoleColor.Green : ConsoleColor.White;
                    Console.Write($"    {tennnisGame.PlayersPoints[0]}  ");
                    Console.ForegroundColor = tennnisGame.getWinner() == 1 ? ConsoleColor.Green : ConsoleColor.White;
                    Console.Write($"    {tennnisGame.PlayersPoints[1]}  ");
 
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write($"    Set {set + 1}  {match.TennisSets[set].getWinningGamesCount(0)} - {match.TennisSets[set].getWinningGamesCount(1)} ");
                Console.Write($"         Winner: {match.TennisPlayers[match.TennisSets[set].getWinner()].Name}  ");
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($" And the Orbis Tennis tournament  Match winner is  {match.TennisPlayers[match.getWinner()].Name}  ");
            Console.WriteLine();
            Console.WriteLine("Press Enter to close the game");
            Console.ReadLine();

        }
    }
}
