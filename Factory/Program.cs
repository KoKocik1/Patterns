using Factory.Model;

public class Program
{
    public static void Main()
    {
        var point = Point.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);
        
        var point2 = Point.NewCartesianPoint(1, 2);
        Console.WriteLine(point2);
    }

}