using System.Windows;
using System.Windows.Controls;

namespace ColorPicker;

public partial class InputComponent : UserControl
{
    public static readonly DependencyProperty LabelContentProperty = 
        DependencyProperty.Register(nameof(LabelContent), typeof(object), typeof(InputComponent));

    public object LabelContent
    {
        get => GetValue(LabelContentProperty); 
        set => SetValue(LabelContentProperty, value);
    }
    
    public static readonly DependencyProperty ValueProperty = 
        DependencyProperty.Register(nameof(Value), typeof(double), typeof(InputComponent));

    public double Value
    {
        get => (double)GetValue(ValueProperty); 
        set => SetValue(ValueProperty, value);
    }
    
    public InputComponent()
    {
        InitializeComponent();
    }
}