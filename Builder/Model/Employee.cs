namespace Builder.Builders;

public class Employee
{
    public string StreetAddress, Postcode, City;
    public string CompanyName, Position;
    public int AnnualIncome;
    
    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
    }
}