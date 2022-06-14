using System;

namespace Chess.Core
{
    public class PieceMaker
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
            int x = coords[0] - 64;
            int y = (int) char.GetNumericValue(coords[1]);
            return Make(pieceCode, x, y);
        }
    }
}
