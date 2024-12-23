using System.Text;

namespace Builder.WhyToUseBuilder;

public static class HtmlCreate
{
    public static void WhyToUseBuilder()
    {
        var sb = new StringBuilder();
        var words = new[] { "hello", "world" };
        sb.Clear();
        sb.AppendLine("<ul>");
        foreach (var word in words)
        {
            sb.AppendLine($"  <li>{word}</li>");
        }

        sb.AppendLine("</ul>");
        Console.WriteLine(sb);
    }

}