/*
    Insaf Sabirzyanov 220P
    Task - "Chess 3"
    12.04.22
*/

using System;

namespace Chess.Core
{
    public abstract class Piece
    {
        protected int x;
        protected int y;

        public Piece(string coord)
        {
            int x2 = coord[0] - 64;
            int y2 = (int)char.GetNumericValue(coord[1]);
        }

        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(MoveController moveController, int x2, int y2)
        {
            if (IsRightMove(x2, y2))
            {
                moveController.Move(this, ToString());
            }
        }
        

        public void Move(MoveController moveController, string coord)
        {
            int x2 = coord[0] - 64;
            int y2 = (int)char.GetNumericValue(coord[1]);
            Move(moveController, x2, y2);
        }

        public abstract bool IsRightMove(int x2, int y2);

        public bool IsRightMove(string coord)
        {
            int x2 = coord[0] - 64;
            int y2 = (int)char.GetNumericValue(coord[1]);
            return IsRightMove(x2, y2);
        }

        public override string ToString()
        {
            return $"{((char)(x + 64))}{y}";
        }
    }
}
