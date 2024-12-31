using Builder.Builders;
using Builder.Extensions;

public class Program
{
    public static void Main()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");
        Console.WriteLine(cb);

        var htmlBuilder = new HtmlBuilder("Ul")
            .AddChild("Li", "hello")
            .AddChild("Li", "world");
        Console.WriteLine(htmlBuilder.ToString());

        var person = Person.New
            .Called("Sarah")
            .WorksAsA("Developer")
            .Build();
        Console.WriteLine(person.ToString());

        // force to specific order
        var car = CarBuilder
            .Create()
            .WithCarType(CarType.Sedan)
            .WithWheelSize(16)
            .Build();
        Console.WriteLine(car.ToString());

        // sealed class, use extension method
        var student = new StudentBuilder()
            .Called("John")
            .StudyAt("University")
            .Build();
        Console.WriteLine(student.ToString());

        // 2 level
        Employee employee = new EmployeeBuilder()
            .works.At("Company")
            .AsA("Developer")
            .Earning(10000)
            .lives.At("City")
            .In("Berlin")
            .WithPostcode("12-345");
        Console.WriteLine(employee.ToString());
    }
}