using DeepCopy.Model;
using static System.Console;

namespace DeepCopy;

public class Program
{
    public static void Main()
    {
        // own interface IDeepCopyable<T> with DeepCopy() method
        // clear usage of DeepCopy() method
        DeepCopyByOwnGenericInterface();

        // using copy constructor
        DeepCopyByCtor();
    }

    private static void DeepCopyByCtor()
    {
        var johnStudent = new Student("John", new SchoolAddress("123 London Road", "London", "UK"));

        //var chris = john;
        var chrisStudent = new Student(johnStudent);

        chrisStudent.Name = "Chris";
        WriteLine(johnStudent);
        WriteLine(chrisStudent);
    }

    private static void DeepCopyByOwnGenericInterface()
    {
        var john = new Employee();
        john.Names = new[] { "John", "Doe" };
        john.Address = new Address { HouseNumber = 123, StreetName = "London Road" };
        john.Salary = 321000;
        var copy = john.DeepCopy();

        copy.Names[1] = "Smith";
        copy.Address.HouseNumber++;
        copy.Salary = 123000;

        WriteLine(john);
        WriteLine(copy);
    }
}