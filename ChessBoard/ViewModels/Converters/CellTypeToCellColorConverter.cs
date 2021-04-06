using ChessBoard.ViewModels.Enums;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ChessBoard
{
    /**
    * @author ${Fabian Falco, Simon Gönitzer}
    *
    */
    public class CellTypeToCellColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ECellType celltype = (ECellType)value;
            switch (celltype)
            {
                case ECellType.Dark:
                    return new SolidColorBrush(Colors.CadetBlue);
                case ECellType.Light:
                    return new SolidColorBrush(Colors.White);
            }
            throw new ArgumentException("Invalid input, could not convert");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
