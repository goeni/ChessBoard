using ChessBoard.ViewModels.Enums;
using ChessBoard.ViewModels.IViewModels;

public class CellViewModel : ICellViewModel
{
    private ECellType _cellType;
    private EChessPieceColor _pieceColor;
    private EChessPieceType _pieceType;
    private bool _isEmpty = false;

    public ECellType CellType {
        get { return _cellType; }
    }

    public EChessPieceColor ChessPieceColor
    {
        get { return _pieceColor; }
    }

    public EChessPieceType ChessPieceType
    {
        get { return _pieceType;  }
    }

    public bool IsEmpty
    {
        get { return _isEmpty; }
        set => _isEmpty = value;
    }

    public void SetPiece(EChessPieceType type, EChessPieceColor color)
    {
        _pieceType = type;
        _pieceColor = color;

        if (_pieceType.Equals(EChessPieceType.None))
        {
            _isEmpty = true;
        }
    }

    public CellViewModel (ECellType cellType)
    {
        _cellType = cellType;
        
    }
}