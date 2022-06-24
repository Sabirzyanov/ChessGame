using System;
using System.Collections.Generic;
using Chess.Core;

namespace ChessConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Piece piece;
            ConsoleMoveController moveController = new ConsoleMoveController();
            while (true)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1. Create Pawn - Pawn");
                Console.WriteLine("2. Create Bishop - Bishop");
                Console.WriteLine("3. Create King - King");
                Console.WriteLine("4. Create Knight - Knight");
                Console.WriteLine("5. Create Queen - Queen");
                Console.WriteLine("6. Create Rook - Rook");

                string figureCode = Console.ReadLine();
                Console.Write("Enter coords as chees - [A-H][1-8]: ");
                string coords = Console.ReadLine().ToUpper();
                piece = PieceMaker.Make(figureCode, coords);

                Console.Write("Enter move coordinates - [A-H][1-8]: ");
                string moveCoords = Console.ReadLine().ToUpper();

                if (piece.IsRightMove(moveCoords.ToUpper()))
                {
                    Console.WriteLine("Can move");
                    piece.Move(moveController, moveCoords);
                    Console.WriteLine(piece);
                }
                else 
                {
                    Console.WriteLine("Can't move");
                    Console.WriteLine(piece);
                }
                break;
            }
        }

    }
}
