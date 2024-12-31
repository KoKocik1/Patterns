namespace Builder.Builders;

public class EmployeeJobBuilder : EmployeeBuilder
{
    public EmployeeJobBuilder(Employee employee)
    {
        this.employee = employee;
    }

    public EmployeeJobBuilder At(string companyName)
    {
        employee.CompanyName = companyName;
        return this;
    }

    public EmployeeJobBuilder AsA(string position)
    {
        employee.Position = position;
        return this;
    }

    public EmployeeJobBuilder Earning(int annualIncome)
    {
        employee.AnnualIncome = annualIncome;
        return this;
    }
}