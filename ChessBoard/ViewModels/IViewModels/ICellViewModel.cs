using ChessBoard.ViewModels.Enums;

namespace ChessBoard.ViewModels.IViewModels
{
    public interface ICellViewModel
    {
        ECellType CellType { get; }
    }
}