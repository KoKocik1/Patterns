namespace Factory.Model;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
    }
}