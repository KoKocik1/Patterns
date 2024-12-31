using Bridge.Interfaces;

namespace Bridge.Models;

public class ElectricEngine : IDrive
{
    public void Start(string vehicle)
    {
        Console.WriteLine($"{vehicle}: driving using Electric");
    }
}