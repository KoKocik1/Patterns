using Singleton.Interfaces;

namespace Singleton.Database;

public class ConfigurableRecordFinder
{
    private IDatabase database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        this.database = database;
    }

    public int GetTotalPopulation(IEnumerable<string> names)
    {
        int result = 0;
        foreach (var name in names)
            result += database.GetPopulation(name);
        return result;
    }
}