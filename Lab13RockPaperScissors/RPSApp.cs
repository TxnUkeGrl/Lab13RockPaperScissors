using System;
using System.Collections.Generic;
using System.Text;
using static Lab13RockPaperScissors.Player;

namespace Lab13RockPaperScissors
{
    class RPSApp
    {   //storing the new object in a field of the class so it's usable outside the method but within the created object
        public HumanPlayer HumanPlayer;

        public void NewHumanPlayer()
        {
            HumanPlayer = new HumanPlayer();
        }

        public Player GetOpponent()
        {
            Console.WriteLine("Rock or Random?");
            var humanSelectOpponent = Console.ReadLine().ToUpper();

            if (humanSelectOpponent == "ROCK")
            {
                return new RockPlayer();
            }
            else if (humanSelectOpponent == "RANDOM")
            {
                return new RandomPlayer();
            }
            else
            {
                Console.WriteLine("Invalid");
                return GetOpponent();
            }
        }
    }
}
