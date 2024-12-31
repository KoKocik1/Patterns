using System.Text;

namespace Builder.Builders;

public class CodeBuilder
{
    private readonly string className;
    private readonly List<(string, string)> fields = new();

    public CodeBuilder(string className)
    {
        this.className = className;
    }

    public CodeBuilder AddField(string name, string type)
    {
        fields.Add((name, type));
        return this;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"public class {className}");
        sb.AppendLine("{");
        foreach (var field in fields) sb.AppendLine($"  public {field.Item2} {field.Item1};");
        sb.AppendLine("}");
        return sb.ToString();
    }
}