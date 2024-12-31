using Adapter.Interface;

namespace Adapter.Extensions;

public static class ExtensionMethods
{
    public static int Area(this IRectangle rc)
    {
        return rc.Width * rc.Height;
    }
}