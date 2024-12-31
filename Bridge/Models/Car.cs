using Bridge.Interfaces;

namespace Bridge.Models;

public class Car : Vehicle
{
    public Car(IDrive drive) : base(drive) => Name = "Car";
    public override void Drive()
    {
        drive.Start(Name);
    }
}