using System.Text;

namespace Singleton.Models;

public class Building
{
    public readonly List<Wall> Walls = new();

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var wall in Walls)
            sb.AppendLine(wall.ToString());
        return sb.ToString();
    }
}