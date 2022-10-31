using System;
using static System.Console;
namespace Rock_Paper_Scissors
{
    class Menu
    {
        private int SelectedTabIndex;
        private string[] Options;

        public Menu(string[] options)
        {
            Options = options;
            SelectedTabIndex = 0;
        }

        private void DisplayOptions()
        {
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedTabIndex)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"<< {currentOption} >>");
            }
            ResetColor();
        }
    }
}
