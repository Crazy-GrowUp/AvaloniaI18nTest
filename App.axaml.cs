using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaI18nTest.ViewModels;
using AvaloniaI18nTest.Views;
using System.Threading;

namespace AvaloniaI18nTest;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        // 不写或者为空就是默认系统语言
        // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(""); 
        // 修改语言
        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh"); 
        // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
       
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

}