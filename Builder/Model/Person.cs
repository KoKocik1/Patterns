namespace Builder.Builders;

public class Person
{
    public string Name;
    public string Position;
    public static Builder New => new();

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }

    public class Builder : PersonJobBuilder<Builder>
    {
    }
}