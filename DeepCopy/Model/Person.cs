using DeepCopy.Interface;

namespace DeepCopy.Model;

public class Person : IDeepCopyable<Person>
{
    public Address Address;
    public string[] Names;

    public Person()
    {
    }

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public virtual void CopyTo(Person target)
    {
        target.Names = (string[])Names.Clone();
        target.Address = Address.DeepCopy();
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Address)}: {Address}";
    }
}