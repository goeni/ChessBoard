using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Media.Media3D;

namespace ChessBoard.ViewModels
{
    public class MainViewModel
    {
        private List<List<CellViewModel>> _cells = new List<List<CellViewModel>>();
        
        public List<List<CellViewModel>> Cells
        {
            get { return _cells; }
        }

        private void SetupCellViewModel(int rows, int cols)
        {
            bool isLight = false;
            for (int i = 0; i < rows; i++)
            {
                isLight = !isLight;
                _cells.Add(new List<CellViewModel>());
                for (int x = 0; x < cols; x++)
                {
                    if (isLight)
                    {
                        _cells[i].Add(new CellViewModel(Enums.ECellType.Light));
                    } else
                    {
                        _cells[i].Add(new CellViewModel(Enums.ECellType.Dark));
                    }
                    isLight = !isLight;
                }
            }

            _cells[0][0].SetPiece(Enums.EChessPieceType.Rook, Enums.EChessPieceColor.Black);
            _cells[0][1].SetPiece(Enums.EChessPieceType.Knight, Enums.EChessPieceColor.Black);
            _cells[0][2].SetPiece(Enums.EChessPieceType.Bishop, Enums.EChessPieceColor.Black);
            _cells[0][3].SetPiece(Enums.EChessPieceType.Queen, Enums.EChessPieceColor.Black);
            _cells[0][4].SetPiece(Enums.EChessPieceType.King, Enums.EChessPieceColor.Black);
            _cells[0][5].SetPiece(Enums.EChessPieceType.Bishop, Enums.EChessPieceColor.Black);
            _cells[0][6].SetPiece(Enums.EChessPieceType.Knight, Enums.EChessPieceColor.Black);
            _cells[0][7].SetPiece(Enums.EChessPieceType.Rook, Enums.EChessPieceColor.Black);

            _cells[1][0].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][1].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][2].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][3].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][4].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][5].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][6].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);
            _cells[1][7].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.Black);

            _cells[7][0].SetPiece(Enums.EChessPieceType.Rook, Enums.EChessPieceColor.White);
            _cells[7][1].SetPiece(Enums.EChessPieceType.Knight, Enums.EChessPieceColor.White);
            _cells[7][2].SetPiece(Enums.EChessPieceType.Bishop, Enums.EChessPieceColor.White);
            _cells[7][3].SetPiece(Enums.EChessPieceType.King, Enums.EChessPieceColor.White);
            _cells[7][4].SetPiece(Enums.EChessPieceType.Queen, Enums.EChessPieceColor.White);
            _cells[7][5].SetPiece(Enums.EChessPieceType.Bishop, Enums.EChessPieceColor.White);
            _cells[7][6].SetPiece(Enums.EChessPieceType.Knight, Enums.EChessPieceColor.White);
            _cells[7][7].SetPiece(Enums.EChessPieceType.Rook, Enums.EChessPieceColor.White);

            _cells[6][0].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][1].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][2].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][3].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][4].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][5].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][6].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
            _cells[6][7].SetPiece(Enums.EChessPieceType.Pawn, Enums.EChessPieceColor.White);
        }

        public MainViewModel()
        {
            SetupCellViewModel(8, 8);
        }
        
    }
}