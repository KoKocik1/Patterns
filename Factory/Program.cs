using Factory.Factory;
using Factory.Model;

public class Program
{
    public static async Task Main(string[] args)
    {
        // simple example
        var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);
        
        // simple example
        var point2 = PointFactory.NewCartesianPoint(1, 2);
        Console.WriteLine(point2);
        
        //async example
        Foo x = await Foo.CreateAsync();
        Console.WriteLine(x.ToString());

        // Additional data about created objects
        var factory = new TrackingThemeFactory();
        var theme1 = factory.CreateTheme(true);
        var theme2 = factory.CreateTheme(false);
        Console.WriteLine(factory.Info);
        
        // Replace data in created objects
        var factory2 = new ReplacableThemeFactory();
        var magicTheme = factory2.CreateTheme(true);
        Console.WriteLine(magicTheme.Value.BgrColor);
        factory2.ReplaceTheme(false);
        Console.WriteLine(magicTheme.Value.BgrColor);
    }

}