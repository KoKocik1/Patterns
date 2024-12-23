using Builder.Builders;

namespace Builder.Interface;

public interface ISpecifyCarType
{
    ISpecifyWheelSize WithCarType(CarType carType);
}