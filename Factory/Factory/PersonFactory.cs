using Factory.Model;

namespace Factory.Factory;

public class PersonFactory
{
    private List<Person> people = new();

    public Person CreatePerson(string name)
    {
        var person=new Person { Id = people.Count, Name = name };
        people.Add(person);
        return person;
    }

}