namespace Builder.Interface;

public interface ISpecifyWheelSize
{
    IBuildCar WithWheelSize(int size);
}