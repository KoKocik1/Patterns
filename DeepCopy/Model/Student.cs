namespace DeepCopy.Model;

public class Student
{
    public SchoolAddress Address;
    public string Name;

    public Student(string name, SchoolAddress address)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public Student(Student other)
    {
        Name = other.Name;
        Address = new SchoolAddress(other.Address);
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
    }
}