namespace Builder.Builders;

public class EmployeeBuilder
{
    protected Employee employee = new();

    public EmployeeJobBuilder works => new(employee);

    public EmployeeAddressBuilder lives => new(employee);

    public static implicit operator Employee(EmployeeBuilder eb)
    {
        return eb.employee;
    }
}