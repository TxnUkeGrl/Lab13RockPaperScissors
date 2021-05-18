using System;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int humanWins = 0;
            int humanLoss = 0;
            bool session = true;

            RPSApp RPSApp = new RPSApp();
            //new human player
            RPSApp.NewHumanPlayer();

            while (session)
            {
                bool humanWon = false;
                bool drawGame = false;
                bool humanLost = false;

                //opponent selected
                Player theOpponent = RPSApp.GetOpponent();

                //human selects r, p, or s
                var humanThrow = RPSApp.HumanPlayer.GenerateRPS();

                //generate opponent throw
                var opponentThrow = theOpponent.GenerateRPS();

                //compare throws
                //are humanWon = true statements necessary?
                if (humanThrow == Player.RPS.rock && opponentThrow == Player.RPS.rock)
                {
                    drawGame = true;
                    session = true;
                }
                else if (humanThrow == Player.RPS.rock && opponentThrow == Player.RPS.paper)
                {
                    humanLost = true;
                }
                else if (humanThrow == Player.RPS.rock && opponentThrow == Player.RPS.scissors)
                {
                    humanWon = true;
                }
                else if (humanThrow == Player.RPS.paper && opponentThrow == Player.RPS.rock)
                {
                    humanWon = true;
                }
                else if (humanThrow == Player.RPS.paper && opponentThrow == Player.RPS.paper)
                {
                    drawGame = true;
                    session = true;
                }
                else if (humanThrow == Player.RPS.paper && opponentThrow == Player.RPS.scissors)
                {
                    humanLost = true;
                }
                else if (humanThrow == Player.RPS.scissors && opponentThrow == Player.RPS.rock)
                {
                    humanLost = true;
                }
                else if (humanThrow == Player.RPS.scissors && opponentThrow == Player.RPS.paper)
                {
                    humanWon = true;
                }
                else if (humanThrow == Player.RPS.scissors && opponentThrow == Player.RPS.scissors)
                {
                    drawGame = true;
                    session = true;
                }

                Console.WriteLine($"Human: {humanThrow} Bot: {opponentThrow}");

                //count wins & losses
                if (humanWon)
                {
                    Console.WriteLine("You win!");
                    humanWins += 1;
                }
                else if (humanLost)
                {
                    Console.WriteLine("Point for Bot!");
                    humanLoss += 1;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }


                Console.WriteLine("Continue? Y/N");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    session = true;
                }
                else
                {
                    session = false;
                }
            }

            Console.WriteLine($"Wins: {humanWins} Loss: {humanLoss}");
            if (humanWins > humanLoss)
            {
                Console.WriteLine("You beat the Bot!");
            }
            else if (humanWins < humanLoss)
            {
                Console.WriteLine("The Bot wins");
            }
            else
            {
                Console.WriteLine("GG, it's a tie!");
            }


        }
        //public static bool validContinue()
        //{
        //    Console.WriteLine("Continue? Y/N");
        //    if (Console.ReadLine().ToUpper() == "Y")
        //    {
        //        session = true;
        //    }
        //    else
        //    {
        //        session = false;
        //    }
        //}
    }
}
