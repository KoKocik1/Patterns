using Factory.Interface;
using Factory.Model;

namespace Factory.Factory;

public class ReplacableThemeFactory
{
    private readonly List<WeakReference<Ref<ITheme>>> themes = new();

    private ITheme createThemeImpl(bool isDark)
    {
        return isDark ? new DarkTheme() : new LightTheme();
    }

    public Ref<ITheme> CreateTheme(bool isDark)
    {
        var themeRef = new Ref<ITheme>(createThemeImpl(isDark));
        themes.Add(new WeakReference<Ref<ITheme>>(themeRef));
        return themeRef;
    }

    public void ReplaceTheme(bool isDark)
    {
        foreach (var theme in themes)
            if (theme.TryGetTarget(out var themeRef))
                themeRef.Value = createThemeImpl(isDark);
    }
}