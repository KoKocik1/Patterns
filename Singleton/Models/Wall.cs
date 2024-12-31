namespace Singleton.Models;

public class Wall
{
    public const int UseAmbient = int.MinValue;
    public int Height;
    public Point Start, End;

    // public Wall(Point start, Point end, int elevation = UseAmbient)
    // {
    //   Start = start;
    //   End = end;
    //   Elevation = elevation;
    // }

    public Wall(Point start, Point end)
    {
        Start = start;
        End = end;
        //Elevation = BuildingContext.Elevation;
        Height = BuildingContext.Current.WallHeight;
    }

    public override string ToString()
    {
        return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}, " +
               $"{nameof(Height)}: {Height}";
    }
}