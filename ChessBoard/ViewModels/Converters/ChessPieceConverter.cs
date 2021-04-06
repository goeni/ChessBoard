using ChessBoard.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ChessBoard
{
    /**
    * @author ${Fabian Falco, Simon Gönitzer}
    *
    */
    class ChessPieceConverter : IMultiValueConverter
    {
        private Dictionary<Tuple<EChessPieceType, EChessPieceColor>, string> _pieceToImageDictionary = 
            new Dictionary<Tuple<EChessPieceType, EChessPieceColor>, string>()
            {
                {key(EChessPieceType.Pawn, EChessPieceColor.Black), "images/pawn_black.png" },
                {key(EChessPieceType.Pawn, EChessPieceColor.White), "images/pawn_white.png" },
                {key(EChessPieceType.Bishop, EChessPieceColor.Black), "images/bishop_black.png" },
                {key(EChessPieceType.Bishop, EChessPieceColor.White), "images/bishop_white.png" },
                {key(EChessPieceType.King, EChessPieceColor.Black), "images/king_black.png" },
                {key(EChessPieceType.King, EChessPieceColor.White), "images/king_white.png" },
                {key(EChessPieceType.Knight, EChessPieceColor.Black), "images/knight_black.png" },
                {key(EChessPieceType.Knight, EChessPieceColor.White), "images/knight_white.png" },
                {key(EChessPieceType.Queen, EChessPieceColor.Black), "images/queen_black.png" },
                {key(EChessPieceType.Queen, EChessPieceColor.White), "images/queen_white.png" },
                {key(EChessPieceType.Rook, EChessPieceColor.Black), "images/rook_black.png" },
                {key(EChessPieceType.Rook, EChessPieceColor.White), "images/rook_white.png" },
            };

        private static Tuple<EChessPieceType, EChessPieceColor> key(EChessPieceType type, EChessPieceColor color)
        { 
            return new Tuple<EChessPieceType, EChessPieceColor>(type, color);
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            EChessPieceType type = (EChessPieceType)values[0];
            EChessPieceColor color = (EChessPieceColor)values[1];

            if (type == EChessPieceType.None || color == EChessPieceColor.None)
            {
                return null;
            }

            return new BitmapImage(
                new Uri(AppDomain.CurrentDomain.BaseDirectory + _pieceToImageDictionary[key(type, color)],
                UriKind.Absolute));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
