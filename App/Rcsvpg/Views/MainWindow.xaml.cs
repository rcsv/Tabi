using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;

namespace App.Rcsvpg.Views;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        MoveAndResize();
    }

    private void MoveAndResize()
    {
        // customize
        var op = OverlappedPresenter.Create();
        op.IsMaximizable = true;
        op.IsMinimizable = true;
        op.IsResizable = true;
        op.IsAlwaysOnTop = false;

        AppWindow.MoveAndResize(
            new Windows.Graphics.RectInt32(
                myAppWidth,
                myAppHeight,
                (int)((1920 / 2.0) * 1.5),
            (int)((1080 / 2.0) * 1.5)));
    }

    private readonly int myAppWidth = 1024;
    private readonly int myAppHeight = 768;
}    
