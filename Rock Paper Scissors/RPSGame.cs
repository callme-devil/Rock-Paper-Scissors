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

            WriteLine(@"
        ██████  ██████  ███████      ██████   █████  ███    ███ ███████ 
        ██   ██ ██   ██ ██          ██       ██   ██ ████  ████ ██      
        ██████  ██████  ███████     ██   ███ ███████ ██ ████ ██ █████   
        ██   ██ ██           ██     ██    ██ ██   ██ ██  ██  ██ ██      
        ██   ██ ██      ███████      ██████  ██   ██ ██      ██ ███████ 

");

            WriteLine("Lets Play Some Rock Paper Scissors Game");

            WriteLine("What Would you Like to Play ? Move With Arrow Keys");

            string[] options = { "Rock", "Paper", "Scissors" };

            Menu mainMenu = new Menu(options);

            mainMenu.DisplayOptions();

            string playerMove = ReadLine();

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

            WriteLine("Press Any Key to Exit ...");
            ReadKey();
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
