namespace Builder.Builders;

public class HtmlBuilder
{
    private HtmlElement root = new();

    public HtmlBuilder(string rootName)
    {
        root.Name = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);
        return this;
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void Clear()
    {
        root = new HtmlElement();
    }
}