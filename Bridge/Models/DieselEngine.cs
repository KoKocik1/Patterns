using Bridge.Interfaces;

namespace Bridge.Models;

public class DieselEngine : IDrive
{
    public void Start(string vehicle)
    {
        Console.WriteLine($"{vehicle}: driving using Diesel");
    }
}