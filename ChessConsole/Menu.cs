using System;

namespace ChessConsole
{
    public class Menu
    {
        private int SelectOption;
        private string Prompt;
        private string[] Options;


        public Menu(string[] options, string prompt)
        {
            Options = options;
            Prompt = prompt;
            SelectOption = 0;
        }

        public Menu(string[] options)
        {
            Options = options;
            SelectOption = 0;
        }

        private void DisplayOption()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string prefix;
                if (i == SelectOption)
                {
                    prefix = "*";
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    prefix = " ";
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                
                Console.WriteLine($" {prefix} <--- {Options[i]} --- >");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey pressedKey;
            do
            {
                Console.Clear();
                DisplayOption();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                pressedKey = keyInfo.Key;

                if (pressedKey == ConsoleKey.UpArrow)
                {
                    SelectOption--;
                    if (SelectOption == -1)
                    {
                        SelectOption = Options.Length - 1;
                    }
                } 
                else if (pressedKey == ConsoleKey.DownArrow)
                {
                    SelectOption++;
                    if (SelectOption == Options.Length)
                    {
                        SelectOption = 0;
                    }
                }
            } while(pressedKey != ConsoleKey.Enter);

            return SelectOption;
        }
    }
}