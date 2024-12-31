using Factory.Factory;
using Factory.Model;

public class Program
{
    public static async Task Main(string[] args)
    {
        // two others functions instead of ctor
        // can't create two ctor with same type (double,double) so
        // replace ctor with two static functions
        PointFactory_Simple();

        // async example
        // usable when u need to create object with async method
        // constructor can't be async
        await AsyncFactoryExample();

        // Additional data about created objects
        // get info about all created themes
        TrackingFactoryExample();

        // Replace data in all created objects
        // all created themes will have the same data after replace
        ReplacableThemeFactoryExample();

        // abstract factory
        AbstractFactoryExample();
        //abstract factory with reflection instead of enum
        AbstractFactory_ReflectionExample();

        //Create persons with automatically id
        SimpleExampleFactory();
    }

    private static void SimpleExampleFactory()
    {
        var personFactory = new PersonFactory();
        var person = personFactory.CreatePerson("John");
        Console.WriteLine(person);
        var person2 = personFactory.CreatePerson("Sarah");
        Console.WriteLine(person2);
    }

    private static void AbstractFactory_ReflectionExample()
    {
        var mashine2 = new HotDrinkMashineRefleksion();
        var drink2 = mashine2.MakeDrink();
        drink2.Consume();
    }

    private static void AbstractFactoryExample()
    {
        var mashine = new HotDrinkMashine();
        var drink = mashine.MakeDrink(HotDrinkMashine.AvailableDrink.Tea, 100);
        drink.Consume();
    }

    private static void ReplacableThemeFactoryExample()
    {
        var factory2 = new ReplacableThemeFactory();
        var magicTheme = factory2.CreateTheme(true);
        Console.WriteLine(magicTheme.Value.BgrColor);
        factory2.ReplaceTheme(false);
        Console.WriteLine(magicTheme.Value.BgrColor);
    }

    private static void TrackingFactoryExample()
    {
        var factory = new TrackingThemeFactory();
        var theme1 = factory.CreateTheme(true);
        var theme2 = factory.CreateTheme(false);
        Console.WriteLine(factory.Info);
    }

    private static async Task AsyncFactoryExample()
    {
        var x = await Foo.CreateAsync();
        Console.WriteLine(x.ToString());
    }

    private static void PointFactory_Simple()
    {
        //two ways to create point

        var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);

        var point2 = Point.Factory.NewCartesianPoint(1, 2);
        Console.WriteLine(point2);
    }
}