namespace Builder.Builders;

public class EmployeeBuilder
{
    protected Employee employee = new Employee();

    public EmployeeJobBuilder works => new EmployeeJobBuilder(employee);
    
    public EmployeeAddressBuilder lives => new EmployeeAddressBuilder(employee);
    
    public static implicit operator Employee(EmployeeBuilder eb)
    {
        return eb.employee;
    }
}
