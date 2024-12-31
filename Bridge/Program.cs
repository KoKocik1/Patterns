using Autofac;
using Bridge.Interfaces;
using Bridge.Models;
using Bridge.Renderers;

public class Program
{
    public class Demo
    {
        static void Main(string[] args)
        {
            // more cleaner and flexible code than creating multiple classes for each combination
            SimpleBridgeExample();
            
            // using dependency injection to set the renderer at runtime
            DependencyInjectionBridge();

            // instead of electricBus, dieselBus, electricCar, dieselCar
            // we have Bus and Car
            // and we can set the engine type at runtime by passing it to the constructor
            SimpleBridgeExample2();
            
        }

        private static void SimpleBridgeExample()
        {
            var raster = new RasterRenderer();
            var vector = new VectorRenderer();
            var circle = new Circle(vector, 5);
            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }

        private static void DependencyInjectionBridge()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(),
                p.Positional<float>(0)));
            using (var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(
                    new PositionalParameter(0, 5.0f)
                );
                circle.Draw();
                circle.Resize(2);
                circle.Draw();
            }
        }

        private static void SimpleBridgeExample2()
        {
            var electricBus = new Bus(new ElectricEngine());
            electricBus.Drive();

            var dieselCat = new Car(new DieselEngine());
            dieselCat.Drive();
        }
    }
    
}