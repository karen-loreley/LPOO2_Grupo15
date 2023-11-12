using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Data;

namespace ClasesBase.Converters
{
    class ConversorDeEstado : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                int duracion = (int)value;

                if (duracion == 0)
                {
                    return new SolidColorBrush(Colors.Green); 
                }
                else if (duracion > 0 && duracion <= 30)
                {
                    return new SolidColorBrush(Colors.LightCoral); 
                }
                else if (duracion > 30 && duracion <= 60)
                {
                    return new SolidColorBrush(Colors.LightSalmon); 
                }
                else
                {
                    return new SolidColorBrush(Colors.DarkRed); 
                }
            }
            return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
