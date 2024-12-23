using System.Text;
using Builder.Builders;

public class Program
{
    public static void Main()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");
        Console.WriteLine(cb);
    }
}

