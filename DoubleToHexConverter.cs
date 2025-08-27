using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ColorPicker;

public class DoubleToHexConverter : IMultiValueConverter
{
    private static string Convert(object value, Type targetType)
    {
        var val = int.Parse(value.ToString());
        return targetType != typeof(string) 
            ? string.Empty
            : $"{val:X2}";
    }

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        var result = "#";
        foreach (var value in values)
        {
            result += Convert(value, targetType);
        }
        
        return result;
        
        // return values.Aggregate("#", (current, value) => current + Convert(value, targetType));
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        return [DependencyProperty.UnsetValue];
    }
}