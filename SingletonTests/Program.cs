using NUnit.Framework;
using Singleton.Database;
using Singleton.Models;
using Singleton.Tests;
using Singleton.Utils;

[TestFixture]
public class SingletonTests
{
    [Test]
    public void IsSingletonTest()
    {
        var db = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;
        Assert.That(db, Is.SameAs(db2));
        Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
    }

    [Test]
    public void SingletonTotalPopulationTest()
    {
        // testing on a live database
        var rf = new SingletonRecordFinder();
        var names = new[] { "Seoul", "Mexico City" };
        var tp = rf.TotalPopulation(names);
        Assert.That(tp, Is.EqualTo(17500000 + 17400000));
    }

    [Test]
    public void DependantTotalPopulationTest()
    {
        var db = new DummyDatabase();
        var rf = new ConfigurableRecordFinder(db);
        Assert.That(
            rf.GetTotalPopulation(new[] { "alpha", "gamma" }),
            Is.EqualTo(4));
    }

    [Test]
    public void SingletonTesterTest()
    {
        var obj = new object();
        Assert.That(SingletonTester.IsSingleton(() => obj), Is.True);
        Assert.That(SingletonTester.IsSingleton(() => new object()), Is.False);
    }
}