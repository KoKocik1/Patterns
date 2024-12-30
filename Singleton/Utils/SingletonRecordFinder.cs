using Singleton.Database;

namespace Singleton.Utils;

public class SingletonRecordFinder
{
    public int TotalPopulation(IEnumerable<string> names)
    {
        int result = 0;
        foreach (var name in names)
            result += SingletonDatabase.Instance.GetPopulation(name);
        return result;
    }
}