using System;
using Chess.Core;

namespace ChessConsole
{
    internal class ConsoleMoveController : MoveController
    {
        public override void Move(Piece piece, string position)
        {
            piece.x = position[0] - 64;
            piece.y = (int) char.GetNumericValue(position[1]);
        }
    }
}
