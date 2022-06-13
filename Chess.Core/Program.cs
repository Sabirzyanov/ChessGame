using System;

namespace Chess.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var king = PieceMaker.Make("King", 1, 1);
            Console.WriteLine(king.IsRightMove(2, 3));
            king.Move(2, 2);
        }
    }
}
