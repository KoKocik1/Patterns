namespace Builder.Builders;

public class Student
{
    public string Name, University;

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(University)}: {University}";
    }
}