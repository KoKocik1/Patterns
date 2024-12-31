using Factory.Interface;

namespace Factory.Model;

public class LightTheme : ITheme
{
    public string TextColor => "Black";
    public string BgrColor => "White";
}