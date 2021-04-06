
using System.Windows;
using ChessBoard.ViewModels;

/**
 * @author ${Fabian Falco, Simon Gönitzer}
 *
 */
namespace ChessBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            
        }
    }
}
