using System;
using static System.Console;
namespace Rock_Paper_Scissors
{
     class RPSGame
     {
         public void Play()
         {
            Title = "== Rock Paper Scissors ==";

            string playerMove = "";
            string computerMove = "";

            if ((computerMove == "Rock" && playerMove == "Paper")
                || (computerMove == "Paper" && playerMove == "Scissors")
                || (computerMove == "Scissors" && playerMove == "Rock"))
            {
                WriteLine("You Won!");
            }
            else if (computerMove == playerMove)
            {
                WriteLine("You Tied!");
            }
            else
            {
                WriteLine("You Lose!");
            }

            WriteLine("Press Any Key to Exit ...");
            ReadKey();
         }
     }
}
