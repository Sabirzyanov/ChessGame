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
        public int x;
        public int y;

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
                moveController.Move(this, ConvertIntToStringCoords(x2, y2));
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

        public string ConvertIntToStringCoords(int x2, int y2)
        {
            return $"{((char)(x2 + 64))}{y2}";
        }

        public string GetCoords()
        {
            return $"{((char)(x + 64))}{y}";
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name}\nCoords: {((char)(x + 64))}{y}";
        }
    }
}
