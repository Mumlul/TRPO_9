using System.Configuration;
using System.Data;
using System.Windows;

namespace TRPO_8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string CurrentTheme { get; set; } = "Styles/Themes/LightTheme.xaml";
    }

}
