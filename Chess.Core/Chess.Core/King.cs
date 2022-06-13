/*
    Insaf Sabirzyanov 220P
    Task - "Chess 3"
    12.04.22
*/

using System;
namespace Chess.Core
{
    public class King : Piece
    {
        public King(string coord) : base(coord) { }
        public King(int x, int y) : base(x, y) { }

        public override bool IsRightMove(int x2, int y2)
        {
            return Math.Abs(x - x2) <= 1
                && Math.Abs(y - y2) <= 1;
        }
    }
}
