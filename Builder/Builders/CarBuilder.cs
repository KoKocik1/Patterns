using Builder.Interface;

namespace Builder.Builders;

public class CarBuilder
{
    private class Impl :
        ISpecifyCarType,
        ISpecifyWheelSize,
        IBuildCar
    {
        private Car _car = new Car();
        public ISpecifyWheelSize WithCarType(CarType carType)
        {
            _car.Type = carType;
            return this;
        }

        public IBuildCar WithWheelSize(int size)
        {
            switch (_car.Type)
            {
                case CarType.CrossOver when size< 17 || size > 20:
                    case CarType.Sedan when size < 15 || size > 17:
                        throw new InvalidOperationException($"Wrong wheel size for {_car.Type}");
            }
            _car.WheelSize= size;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
    public static ISpecifyCarType Create() => new Impl();
}