namespace Builder.Builders;

public class Employee
{
    public int AnnualIncome;
    public string CompanyName, Position;
    public string StreetAddress, Postcode, City;

    public override string ToString()
    {
        return
            $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
    }
}