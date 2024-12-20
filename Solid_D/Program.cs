public enum Relationship
{
    Parent,
    Child,
    Sibling
}

public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}
public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}
//low-level
public class Relationships : IRelationshipBrowser
{
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    //public List<(Person, Relationship, Person)> Relations => relations;
    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return relations.Where(
            x => x.Item1.Name == name &&
                 x.Item2 == Relationship.Parent
        ).Select(r=>r.Item3);
    }
}

//high-level
public class Research
{
    // public Research(Relationships relationships)
    // {
    //     //high-level module should not depend on low-level module
    //     //we should depend on abstractions
    //     foreach (var r in relationships.Relations.Where(
    //         x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent
    //     ))
    //     {
    //         Console.WriteLine($"John has a child called {r.Item3.Name}");
    //     }
    // }

    public Research(IRelationshipBrowser browser)
    {
        foreach (var p in browser.FindAllChildrenOf("John"))
        {
            Console.WriteLine($"John has a child called {p.Name}");
        }
    }
    static void Main()
    {
        var parent = new Person("John");
        var child1 = new Person("Chris");
        var child2 = new Person("Matt");

        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);

        new Research(relationships);
    }
}

