using System;
using static System.Console;
namespace Rock_Paper_Scissors
{
     class RPSGame
     {

         public void Play()
         {
            Title = "== Rock Paper Scissors ==";
            WriteLine("Lets Play Some Rock Paper Scissors Game");

            WriteLine("What Would you Like to Play ? Move With Arrow Keys");

            string playerMove = "";

            Random rng = new Random();
            int randomChoice = rng.Next(0,3);

            string computerMove = "";

            if (randomChoice == 0)
            {
                computerMove = "Rock";
            }
            else if (randomChoice == 1)
            {
                computerMove = "Paper";
            }
            else
            {
                computerMove = "Scissors";
            }

            WriteLine($"You Played {playerMove} . . .");
            WriteLine($"Computer Player {computerMove} . . .");


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
