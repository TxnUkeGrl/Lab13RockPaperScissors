using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class HumanPlayer : Player
    {
        //Constructor to create new name for human player
        public HumanPlayer()
        {
            Console.WriteLine("Name?");
            Name = Console.ReadLine();
        }

        public override RPS GenerateRPS()
        {
            Console.WriteLine("R, P, or S?");
            string searchRPS = Console.ReadLine().ToLower();

            switch (searchRPS)
            {
                case "r":
                    return RPS.rock;

                case "p":
                    return RPS.paper;

                case "s":
                    return RPS.scissors;

                default:
                    return GenerateRPS();
            }
        }
    }
}
