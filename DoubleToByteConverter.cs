using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ColorPicker;

public class DoubleToByteConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (targetType != typeof(byte)) return DependencyProperty.UnsetValue;
        
        var val = byte.Parse(value.ToString());
        return val;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return DependencyProperty.UnsetValue;
    }
}