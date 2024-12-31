using DeepCopy.Interface;

namespace DeepCopy.Model;

public class Address : IDeepCopyable<Address>
{
    public int HouseNumber;
    public string StreetName;

    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }

    public Address()
    {
    }

    public void CopyTo(Address target)
    {
        target.StreetName = StreetName;
        target.HouseNumber = HouseNumber;
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}