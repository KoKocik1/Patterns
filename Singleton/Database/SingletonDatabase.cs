using MoreLinq;
using Singleton.Interfaces;

namespace Singleton.Database;

using static Console;

public class SingletonDatabase : IDatabase
{
    // laziness + thread safety
    private static readonly Lazy<SingletonDatabase> instance = new(() =>
    {
        Count++;
        return new SingletonDatabase();
    });

    private readonly Dictionary<string, int> capitals;

    private SingletonDatabase()
    {
        WriteLine("Initializing database");

        capitals = File.ReadAllLines(
                Path.Combine(
                    new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "Files", "capitals.txt")
            )
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1)));
    }

    public static int Count { get; private set; }

    public static IDatabase Instance => instance.Value;

    public int GetPopulation(string name)
    {
        return capitals[name];
    }
}