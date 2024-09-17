using Avalonia.Controls;
using ReactiveUI.SourceGenerators;

namespace AvaloniaApplication1;

[IViewFor(nameof(MainViewModel))]
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
