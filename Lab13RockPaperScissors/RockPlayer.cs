using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class RockPlayer : Player
    {
        public override RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }
}
