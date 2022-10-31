using System;
using static System.Console;
namespace Rock_Paper_Scissors
{
     class RPSGame
     {

         private string RockGraphic = @"
        _______
    ---'   ____)
          (_____)
          (_____)
          (____)
    ---.__(___)
";

         private string PaperGraphic = @"
         _______
    ---'    ____)____
               ______)
              _______)
             _______)
    ---.__________)
";

         private string ScissorsGraphic = @"
        _______
    ---'   ____)____
              ______)
           __________)
          (____)
    ---.__(___)
";


        public void Play()
         {
            Title = "== RPS Game ==";

            string prompt = "Lets Play Some Rock Paper Scissors Game";

            string[] options = { "Rock", "Paper", "Scissors" , "Exit"};

            string playerMove = "";

            Menu mainMenu = new Menu(prompt,options);

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    playerMove = "Rock";
                    break;
                case 1:
                    playerMove = "Paper";
                    break;
                case 2:
                    playerMove = "Scissors";
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }


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

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"\n You Played {playerMove} . . .");
            DisplayMoveGraphic(playerMove);

            ForegroundColor = ConsoleColor.Red;
            WriteLine($"\n The Computer Played {computerMove} . . .");
            DisplayMoveGraphic(computerMove);


            if ((computerMove == "Rock" && playerMove == "Paper")
                || (computerMove == "Paper" && playerMove == "Scissors")
                || (computerMove == "Scissors" && playerMove == "Rock"))
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("You Won!");
            }
            else if (computerMove == playerMove)
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("You Tied!");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("You Lose!");
            }
            ResetColor();
            WriteLine("Press Any Key to Play Again");
            ReadKey();
            Play();

        }

        private void DisplayMoveGraphic(string move)
        {
            if (move == "Rock")
            {
                WriteLine(RockGraphic);
            }
            else if (move == "Paper")
            {
                WriteLine(PaperGraphic);
            }
            else if (move == "Scissors")
            {
                WriteLine(ScissorsGraphic);
            }
        }
     }
}
