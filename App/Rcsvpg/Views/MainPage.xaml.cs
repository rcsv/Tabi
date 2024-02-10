using Microsoft.Extensions.DependencyInjection;
using App.Rcsvpg.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace App.Rcsvpg.Views;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.ViewModel = App.HostContainer.Services.GetService<MainViewModel>();
        this.InitializeComponent();
        
    }

    public MainViewModel ViewModel { get; set; }
}


