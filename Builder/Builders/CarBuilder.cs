using Builder.Interface;

namespace Builder.Builders;

public class CarBuilder
{
    public static ISpecifyCarType Create()
    {
        return new Impl();
    }

    private class Impl :
        ISpecifyCarType,
        ISpecifyWheelSize,
        IBuildCar
    {
        private readonly Car _car = new();

        public Car Build()
        {
            return _car;
        }

        public ISpecifyWheelSize WithCarType(CarType carType)
        {
            _car.Type = carType;
            return this;
        }

        public IBuildCar WithWheelSize(int size)
        {
            switch (_car.Type)
            {
                case CarType.CrossOver when size < 17 || size > 20:
                case CarType.Sedan when size < 15 || size > 17:
                    throw new InvalidOperationException($"Wrong wheel size for {_car.Type}");
            }

            _car.WheelSize = size;
            return this;
        }
    }
}