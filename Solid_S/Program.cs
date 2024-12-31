public class Journal
{
    private static int count;
    private readonly List<string> entries = new();

    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count; // memento
    }

    public void RemoveEntry(int index)
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}

public class Persistence
{
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
            File.WriteAllText(filename, journal.ToString());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var j = new Journal();
        j.AddEntry("I cried today.");
        j.AddEntry("I ate a bug.");
        Console.WriteLine(j);

        var p = new Persistence();
        var filename = @"C:\temp\journal.txt";
        p.SaveToFile(j, filename, true);
    }
}