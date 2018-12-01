using System;
using ApplocationCore.Entities;

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

            var Player1 = new Player(1, player1Name);
            var Player2 = new Player(2, player2Name);
            
            Console.WriteLine("Press Enter to close the game");
            Console.ReadLine();
        }
    }
}
