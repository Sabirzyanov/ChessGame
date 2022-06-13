/*
    Insaf Sabirzyanov 220P
    Task - "Chess 3"
    12.04.22
*/

using System;
namespace Chess.Core
{
    public class Knight : Piece
    {
        public Knight(string coord) : base(coord) { }
        public Knight(int x, int y) : base(x, y) { }

        public override bool IsRightMove(int x2, int y2)
        {
            return Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2) == 5;
        }
    }
}
