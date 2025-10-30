using System.Windows;

namespace TRPO_8.Service;

static class ThemeHelper
{
    private static readonly string[] _themePath = {
        "Styles/Themes/LightTheme.xaml",
        "Styles/themes/DarkTheme.xaml"
    };
    public static string Current
    {
        get => App.CurrentTheme;
        set => App.CurrentTheme = value;
    }
    public static void Apply(string themePath)
    {
        var newTheme = new ResourceDictionary
        {
            Source = new Uri(themePath, UriKind.Relative)
        };
        var oldTheme = Application.Current.Resources.MergedDictionaries
            .FirstOrDefault(d => _themePath.Any(path =>
                d.Source != null && d.Source.OriginalString.EndsWith(path,
                    StringComparison.OrdinalIgnoreCase)));
        if (oldTheme != null) {
            int index =
                Application.Current.Resources.MergedDictionaries.IndexOf(oldTheme);
            Application.Current.Resources.MergedDictionaries[index] =
                newTheme;
        }
        else
        {
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }
        Current = themePath;
    }
    public static void ApplySaved()
    {
        var theme = Current;
        Apply(theme);
    }
    public static void Toggle()
    {
        var newTheme = Current == _themePath[0]
            ? _themePath[1]
            : _themePath[0];
        Apply(newTheme);
    }
}