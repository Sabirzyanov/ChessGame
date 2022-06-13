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
            x = ConvertCharToInt(coord[0]);
            y = ConvertCharToInt(coord[1]);

        }

        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x2, int y2)
        {
            if (IsRightMove(x2, y2))
            {
                x = x2;
                y = y2;
            }
        }
        

        public void Move(string coord)
        {
            int x2 = ConvertCharToInt(coord[0]);
            int y2 = ConvertCharToInt(coord[1]);
            Move(x2, y2);
        }

        public abstract bool IsRightMove(int x2, int y2);

        public bool IsRightMove(string coords)
        {
            int x2 = ConvertCharToInt(coords[0]);
            int y2 = ConvertCharToInt(coords[1]);
            return IsRightMove(x2, y2);
        }

        public override string ToString()
        {
            return $"{ConvertIntToChar(x)}{ConvertIntToChar(y)}";
        }

        public int ConvertCharToInt(char c)
        {
            return Convert.ToInt32(c);
        }

        public char ConvertIntToChar(int i)
        {
            return (char)(i + 64);
        }
    }
}
