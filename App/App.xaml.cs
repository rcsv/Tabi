using App.Rcsvpg.Services;
using App.Rcsvpg.ViewModels;
using App.Rcsvpg.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;

namespace App;


public partial class App : Application
{
    public static IHost HostContainer { get; private set; }

    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        m_window = new MainWindow();

        // Add Frame + Insert Page
        var rootFrame = new Frame();
        RegisterComponents(rootFrame);
        rootFrame.NavigationFailed += RootFrame_NavigationFailed;
        rootFrame.Navigate(typeof(MainPage), args);

        m_window.Content = rootFrame;
        m_window.Activate();
    }

    private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
    {
        throw new Exception($"Error loading page {e.SourcePageType.FullName}");
    }

    // RegisterComponents
    // アプリケーションを動作させるための関連情報を呼び出しておく
    //
    private void RegisterComponents(Frame rootFrame)
    {
        var nS = new NavigationService(rootFrame);

        nS.Configure(nameof(MainPage), typeof(MainPage));       // MainPage
        //nS.Configure(nameof(BuddyPage), typeof(BuddyPage));

        HostContainer = Host.CreateDefaultBuilder().ConfigureServices(services =>
        {
            services.AddSingleton<INavigationService>(nS);
            // AddSingleton<IDataService, DataService>(); ... not implemented
            services.AddTransient<MainViewModel>();

        }).Build();

    }

    private Window m_window;
}
