/*
    Insaf Sabirzyanov 220P
    Task - "Chess 3"
    12.04.22
*/

using System;
namespace Chess.Core
{
    public class Bishop : Piece
    {
        public Bishop(string coord) : base(coord) { }
        public Bishop(int x, int y) : base(x, y) { }

        public override bool IsRightMove(int x2, int y2)
        {
            return Math.Abs(x2 - x) == Math.Abs(y2 - y);
        }
    }
}
