using System.Text;
using Factory.Interface;
using Factory.Model;

namespace Factory.Factory;

public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> themes = new();

    public ITheme CreateTheme(bool isDark)
    {
        ITheme theme = isDark ? new DarkTheme() : new LightTheme();
        themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var theme in themes)
            {
                if (theme.TryGetTarget(out var t))
                {
                    sb.AppendLine($"Theme: {t.GetType().Name}");
                }
            }

            return sb.ToString();
        }
    }
}