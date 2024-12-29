using Factory.Interface;

namespace Factory.Model;

public class DarkTheme : ITheme
{
    public string TextColor => "White";
    public string BgrColor => "Dark Gray";
}