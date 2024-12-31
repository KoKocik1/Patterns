using Bridge.Interfaces;

namespace Bridge.Models;

public abstract class Vehicle
{
    protected IDrive drive;
    public string Name { get; set; }

    protected Vehicle(IDrive drive)
    {
        this.drive = drive;
    }
    
    public abstract void Drive();
}