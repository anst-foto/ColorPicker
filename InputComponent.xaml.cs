using System.Windows;
using System.Windows.Controls;

namespace ColorPicker;

public partial class InputComponent : UserControl
{
    public string LabelText { get; set; }
    public event Action<double> Action;
    
    public InputComponent()
    {
        InitializeComponent();
        
        Loaded += (sender, args) => Label_Input.Content = LabelText;
    }

    private void Input_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        Action.Invoke(e.NewValue);
    }
}