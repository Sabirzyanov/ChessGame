using System;
using System.Collections.Generic;
using Chess.Core;

namespace ChessConsole
{
    internal class Program
    {
        static List<Piece> pieces = new List<Piece>();
        static string _selectedFigureType = "";
        static void Main(string[] args)
        {
            
            StartMenu();
        }

        public static void StartMenu()
        {
            string[] options =
            {
                "Add figure", "Exit"
            };
            Menu menu = new Menu(options);
            int selectedOption = menu.Run();

            switch (selectedOption)
            {
                case 0:
                    SelectFigure();
                    break;
                case 1:
                    Exit();
                    break;
            }
        }

        private static void SelectFigure()
        {
            string[] figures =
            {
                "Bishop", "King", "Knight", "Pawn", "Queen", "Rook", "Exit"
            };
            Menu menu = new Menu(figures);
            int selectedOption = menu.Run();
            if (selectedOption == figures.Length - 1)
            {
                StartMenu();
            }
            _selectedFigureType = figures[selectedOption];

        }

        private void AddFigure()
        {
            Console.Write("Enter Coordinates of Piece as Chess - (A-H)(1-8):");
            string coords = Console.ReadLine();

        }

        private static void Exit()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
