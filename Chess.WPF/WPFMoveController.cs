using Chess.Core;
using System.Windows;
using System.Windows.Controls;

namespace Chess.WPF
{
    internal class WPFMoveController : MoveController
    {
        Grid grid;
        public WPFMoveController(Grid grid)
        {
            this.grid = grid;
        }
        public override void Move(Piece piece, string coords)
        {
            Button destinationCell = (Button) grid.FindName(coords);
            Button originCell = (Button)grid.FindName(piece.GetCoords());
            if (piece.IsRightMove(coords))
            {
                originCell.Content = null;
                destinationCell.Content = piece.GetType().Name;
            }
        }

        public void ValidateCell(Piece piece, string coords)
        {
            Button destinationCell = (Button)grid.FindName(coords);
            if (destinationCell.Content is null)
            {
                if (piece.IsRightMove(coords))
                {
                    destinationCell.Content = "Can move";
                }
                else 
                {
                    destinationCell.Content = "Can't move";
                }
            }
        }
    }
}
