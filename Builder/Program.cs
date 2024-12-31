using Builder.Builders;
using Builder.Extensions;

public class Program
{
    public static void Main()
    {
        //add fields to class (type and name)
        // clear way to create class and add fields to it
        ClassBuilderExample();

        //add child elements li to element ul 
        HtmlBuilderExample();

        //build by steps => new, name, workAsA, build()
        PersonBuilderExample();

        // force to specific order
        // first car type then wheel size
        // using interfaces to force order
        CarBuildExample();

        // sealed class
        // use extension method
        StudentBuildExample();

        // 2 levels
        // 1. Employee.Works -> set job details
        // 2. Employee.Lives -> set address details
        EmployeeBuilderExample();
    }

    private static void EmployeeBuilderExample()
    {
        Employee employee = new EmployeeBuilder()
            .works.At("Company")
            .AsA("Developer")
            .Earning(10000)
            .lives.At("City")
            .In("Berlin")
            .WithPostcode("12-345");
        Console.WriteLine(employee.ToString());
    }

    private static void StudentBuildExample()
    {
        var student = new StudentBuilder()
            .Called("John")
            .StudyAt("University")
            .Build();
        Console.WriteLine(student.ToString());
    }

    private static void CarBuildExample()
    {
        var car = CarBuilder
            .Create()
            .WithCarType(CarType.Sedan)
            .WithWheelSize(16)
            .Build();
        Console.WriteLine(car.ToString());
    }

    private static void PersonBuilderExample()
    {
        var person = Person.New
            .Called("Sarah")
            .WorksAsA("Developer")
            .Build();
        Console.WriteLine(person.ToString());
    }

    private static void HtmlBuilderExample()
    {
        var htmlBuilder = new HtmlBuilder("Ul")
            .AddChild("Li", "hello")
            .AddChild("Li", "world");
        Console.WriteLine(htmlBuilder.ToString());
    }

    private static void ClassBuilderExample()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");
        Console.WriteLine(cb);
    }
}