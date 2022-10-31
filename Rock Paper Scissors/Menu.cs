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

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedTabIndex--;
                    if (SelectedTabIndex == -1)
                    {
                        SelectedTabIndex = Options.Length - 1;
                    }
                }

                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedTabIndex++;
                    if (SelectedTabIndex == Options.Length)
                    {
                        SelectedTabIndex = 0;
                    }
                }


            } while (keyPressed != ConsoleKey.Enter);

            return SelectedTabIndex;
        }
    }
}
