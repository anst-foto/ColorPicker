using System.Windows;
using System.Windows.Media;

namespace ColorPicker;

public partial class MainWindow : Window
{
    private byte _alpha;
    private byte _red;
    private byte _green;
    private byte _blue;
    
    public MainWindow()
    {
        _alpha = 255;
        _red = 0;
        _green = 0;
        _blue = 0;
        
        InitializeComponent();
    }
    
    private void Alpha_OnAction(double value)
    {
        _alpha = (byte)value;
        FillColor();
    }
    
    private void Red_OnAction(double value)
    {
        _red = (byte)value;
        FillColor();
    }
    private void Green_OnAction(double value)
    {
        _green = (byte)value;
        FillColor();
    }
    private void Blue_OnAction(double value)
    {
        _blue = (byte)value;
        FillColor();
    }

    private void FillColor()
    {
        var color = Color.FromArgb(_alpha, _red, _green, _blue);
        Rectangle.Fill = new SolidColorBrush(color);
        
        RGBA.Text = $"RGBA: {_red}, {_green}, {_blue}, {_alpha}";
        HEX.Text = $"HEX: #{_red:X2}{_green:X2}{_blue:X2}{_alpha:X2}";
    }
}