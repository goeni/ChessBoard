using ChessBoard.ViewModels.Enums;

namespace ChessBoard.ViewModels.IViewModels
{
    public interface ICellViewModel
    {
        ECellType CellType { get; }
        EChessPieceColor ChessPieceColor { get; }
        bool IsEmpty { get; }
        EChessPieceType ChessPieceType { get; }
        void SetPiece(EChessPieceType type, EChessPieceColor color);
    }
}