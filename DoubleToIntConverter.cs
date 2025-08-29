using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ColorPicker;

public class DoubleToIntConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        (int)(double)value;

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => 
        DependencyProperty.UnsetValue;
}