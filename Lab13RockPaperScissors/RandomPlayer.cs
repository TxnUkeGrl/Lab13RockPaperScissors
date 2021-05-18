using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class RandomPlayer : Player
    {
        public override RPS GenerateRPS()
        {
            var randomThrow = new Random();
            randomThrow.Next(0, 3);
            return (RPS)randomThrow.Next(0, 3);


        }
    }
}
