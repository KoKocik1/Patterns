namespace Builder.Builders;

public class HtmlBuilder
{
    HtmlElement root = new HtmlElement();
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
    public override string ToString() => root.ToString();
    public void Clear() => root = new HtmlElement();
}