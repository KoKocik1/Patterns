using Factory.Model;

public class Program
{
    public static async Task Main(string[] args)
    {
        var point = Point.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);
        
        var point2 = Point.NewCartesianPoint(1, 2);
        Console.WriteLine(point2);
        
        Foo x = await Foo.CreateAsync();
        Console.WriteLine(x.ToString());
    }

}