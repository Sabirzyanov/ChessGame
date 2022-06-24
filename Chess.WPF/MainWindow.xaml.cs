using Chess.Core;
using System.Windows;
using System.Windows.Controls;

namespace Chess.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WPFMoveController _moveController;

        private Piece? _selectedPiece;
        private bool _isMoving;
        private bool _isAdding;
        private string _selectedFigureCode;

        public MainWindow()
        {
            InitializeComponent();
            _moveController = new WPFMoveController(grid);
        }

        private void Cell_MouseRightButtonDown(object sender, RoutedEventArgs e)
        {
            Button cell = (Button)sender;

            if (cell.Content is not null)
            {
                cell.Content = null;
            }
        }

        private void Cell_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Button cell = (Button)sender;
            string position = cell.Name;

            if (_isAdding && cell.Content == null)
            {
                Piece piece = PieceMaker.Make(_selectedFigureCode, position);
                cell.Content = piece.GetType().Name;
                _isAdding = false;
            }
            else if (_isMoving)
            {
                _moveController.Move(_selectedPiece, position);
                _isMoving = false;
            }
            else 
            {   
                _selectedPiece = PieceMaker.Make(cell.Content?.ToString(), position);
                if (_selectedPiece != null)
                {
                    _isMoving = true;
                }
            }
        }

        private void Cell_MouseEnter(object sender, RoutedEventArgs e)
        {
            Button destinationCell = (Button)sender;
            if (_isMoving)
            {
                _moveController.ValidateCell(_selectedPiece, destinationCell.Name);
            }
        }

        private void Cell_MouseLeave(object sender, RoutedEventArgs e)
        {
            Button destinationCell = (Button)sender;
            if (destinationCell.Content == "Can't move" || destinationCell.Content == "Can move")
            {
                destinationCell.Content = null;
            }
        }

        private void FigureSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string comboBoxContent = (string)((TextBlock)((ComboBox)sender).SelectedValue).Text;
            _selectedFigureCode = comboBoxContent;
        }

        private void AddPieceButton_Click(object sender, RoutedEventArgs e)
        {
            _isAdding = true;
        }
    }
}
