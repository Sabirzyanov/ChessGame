/*
    Insaf Sabirzyanov 220P
    Task - "Chess 3"
    12.04.22
*/

using System;
namespace Chess.Core
{
    public class Pawn : Piece
    {
        public Pawn(string coord) : base(coord) { }
        public Pawn(int x, int y) : base(x, y) { }

        public override bool IsRightMove(int x2, int y2)
        {
            return (y2 - y) <= 2 && (x == x2);
        }
    }
}
