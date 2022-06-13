/*
    Insaf Sabirzyanov 220P
    Task - "Chess 3"
    12.04.22
*/

using System;
namespace Chess.Core
{
    public class Rook : Piece
    {
        public Rook(string coord) : base (coord) { }
        public Rook(int x, int y) : base (x, y) { }

        public override bool IsRightMove(int x2, int y2)
        {
            return (x == x2) || (y == y2);
        }
    }
}
