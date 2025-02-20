using AvaloniaI18nTest.Properties;
using prop = AvaloniaI18nTest.Properties;
namespace AvaloniaI18nTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";
        public string ResxName { get; } = Resource.Name;
        public string ResxName2 { get; } = prop.Resource.Name;
        
    }
}
