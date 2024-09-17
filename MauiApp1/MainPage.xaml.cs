using System;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls;
using ReactiveUI.SourceGenerators;

namespace MauiApp1;

[IViewFor(nameof(MainViewModel))]
public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}
