using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    abstract class Player
    {
        public enum RPS
        {
            rock, paper, scissors
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public abstract RPS GenerateRPS();
        
    }
}
