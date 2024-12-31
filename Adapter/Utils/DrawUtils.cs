using Adapter.Adapter;
using Adapter.Model;
using MoreLinq.Extensions;

namespace Adapter.Utils;

public static class DrawUtils
{
    // the interface we have
    public static void DrawPoint(Point p)
    {
        Console.Write(".");
    }

    public static void Draw(List<VectorObject> vectorObjects)
    {
        foreach (var vo in vectorObjects)
        {
            foreach (var line in vo)
            {
                var adapter = new LineToPointAdapter(line);
                adapter.ForEach(DrawPoint);
            }
        }
    }
}