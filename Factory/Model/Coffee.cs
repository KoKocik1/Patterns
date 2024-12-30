using Factory.Interface;

namespace Factory.Model;

public class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This coffee is sensational!");
    }
}