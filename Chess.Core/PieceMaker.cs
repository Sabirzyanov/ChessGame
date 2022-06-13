using System;

namespace Chess.Core
{
    class PieceMaker
    {
        static public Piece Make(string pieceCode, int x, int y)
        {
            return pieceCode switch
            {
                "Pawn" => new Pawn(x, y),
                "Bishop" => new Bishop(x, y),
                "King" => new King(x, y),
                "Knight" => new Knight(x, y),
                "Queen" => new Queen(x, y),
                "Rook" => new Rook(x, y),
                _ => new Pawn(x, y)
            };
        }

        static public Piece Make(string pieceCode, string coords)
        {
            int x = Convert.ToInt32(coords[0]);
            int y = Convert.ToInt32(coords[1]);
            return Make(pieceCode, x, y);
        }
    }
}
