using Autofac;
using Singleton.Database;
using Singleton.Models;
using static System.Console;

namespace Singleton;

public class Program
{
    public static void Main()
    {
        var db = SingletonDatabase.Instance;

        // works just fine while you're working with a real database.
        var city = "Tokyo";
        WriteLine($"{city} has population {db.GetPopulation(city)}");

        // Dependency Injection
        var builder = new ContainerBuilder();
        builder.RegisterType<EventBroker>().SingleInstance();
        builder.RegisterType<Foo>();

        using (var c = builder.Build())
        {
            var foo1 = c.Resolve<Foo>();
            var foo2 = c.Resolve<Foo>();

            WriteLine(ReferenceEquals(foo1, foo2));
            WriteLine(ReferenceEquals(foo1.Broker, foo2.Broker));
        }

        // MonoState
        var ceo = new ChiefExecutiveOfficer();
        ceo.Name = "Adam Smith";
        ceo.Age = 55;

        var ceo2 = new ChiefExecutiveOfficer();
        WriteLine(ceo2);

        // Singleton per thread
        var t1 = Task.Factory.StartNew(() => { WriteLine("t1: " + PerThreadSingleton.Instance.Id); });
        var t2 = Task.Factory.StartNew(() =>
        {
            WriteLine("t2: " + PerThreadSingleton.Instance.Id);
            WriteLine("t2 again: " + PerThreadSingleton.Instance.Id);
        });
        Task.WaitAll(t1, t2);

        //Ambient content
        var house = new Building();

        using (new BuildingContext(3000))
        {
            // ground floor h=3000;
            house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0) /*, e*/));
            house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000) /*, e*/));

            // first floor h=3500;
            using (new BuildingContext(3500))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0) /*, e*/));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000) /*, e*/));
            }

            // back to ground again h=3000;
            house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000) /*, e*/));
        }

        WriteLine(house);
    }
}