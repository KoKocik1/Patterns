namespace DeepCopy.Model;

public class SchoolAddress
{
    public string StreetAddress, City, Country;

    public SchoolAddress(string streetAddress, string city, string country)
    {
        StreetAddress = streetAddress ?? throw new ArgumentNullException(nameof(streetAddress));
        City = city ?? throw new ArgumentNullException(nameof(city));
        Country = country ?? throw new ArgumentNullException(nameof(country));
    }

    public SchoolAddress(SchoolAddress other)
    {
        StreetAddress = other.StreetAddress;
        City = other.City;
        Country = other.Country;
    }

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(City)}: {City}, {nameof(Country)}: {Country}";
    }
}