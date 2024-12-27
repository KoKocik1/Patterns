namespace Builder.Builders;

public class EmployeeAddressBuilder: EmployeeBuilder
{
    public EmployeeAddressBuilder(Employee employee)
    {
        this.employee = employee;
    }
    
    public EmployeeAddressBuilder At(string streetAddress)
    {
        employee.StreetAddress = streetAddress;
        return this;
    }
    
    public EmployeeAddressBuilder WithPostcode(string postcode)
    {
        employee.Postcode = postcode;
        return this;
    }
    
    public EmployeeAddressBuilder In(string city)
    {
        employee.City = city;
        return this;
    }
    
    
    
}