namespace DeepCopy.Model;

public class Student
{
    public string Name;
    public SchoolAddress Address;

    public Student(string name, SchoolAddress address)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
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