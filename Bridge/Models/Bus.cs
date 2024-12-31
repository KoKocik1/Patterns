using Bridge.Interfaces;

namespace Bridge.Models;

public class Bus : Vehicle
{
    public Bus(IDrive drive) : base(drive) => Name = "Bus";
    public override void Drive()
    {
        drive.Start(Name);
    }
}