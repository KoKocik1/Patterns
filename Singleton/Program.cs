using Autofac;
using static System.Console;
using Singleton.Database;
using Singleton.Models;

namespace Singleton
{
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
    }
  }
}