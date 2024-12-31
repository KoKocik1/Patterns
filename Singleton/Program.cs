using Autofac;
using Singleton.Database;
using Singleton.Models;
using static System.Console;

namespace Singleton;

public class Program
{
    public static void Main()
    {
        // Singleton for database
        DatabaseSingleton();

        // Dependency Injection
        DependencyInjectionSingleton();

        // MonoState - two objects share the same state
        MonoStateSingleton();

        // Create Singleton per thread
        // New object in new thread has different id
        // Second object in the same thread has the same id
        SingletonPerThread();

        //Ambient content 
        // some objects share the same context
        // first floor walls has different height than ground floor walls
        AmbientContentSingleton();
    }

    private static void AmbientContentSingleton()
    {
        var house = new Building();

        using (new BuildingContext(3000))
        {
            // ground floor h=3000;
            house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
            house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));

            // first floor h=3500;
            using (new BuildingContext(3500))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
            }

            // back to ground again h=3000;
            house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
        }

        WriteLine(house);
    }

    private static void SingletonPerThread()
    {
        var t1 = Task.Factory.StartNew(() => { WriteLine("t1: " + PerThreadSingleton.Instance.Id); });
        var t2 = Task.Factory.StartNew(() =>
        {
            WriteLine("t2: " + PerThreadSingleton.Instance.Id);
            WriteLine("t2 again: " + PerThreadSingleton.Instance.Id);
        });
        Task.WaitAll(t1, t2);
    }

    private static void MonoStateSingleton()
    {
        var ceo = new ChiefExecutiveOfficer();
        ceo.Name = "Adam Smith";
        ceo.Age = 55;

        var ceo2 = new ChiefExecutiveOfficer();
        WriteLine(ceo2);
    }

    private static void DependencyInjectionSingleton()
    {
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
    }

    private static void DatabaseSingleton()
    {
        var db = SingletonDatabase.Instance;
        var city = "Tokyo";
        WriteLine($"{city} has population {db.GetPopulation(city)}");
    }
}