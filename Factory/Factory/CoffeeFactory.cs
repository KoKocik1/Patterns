using Factory.Interface;
using Factory.Model;

namespace Factory.Factory;

public class CoffeeFactory :IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
        return new Coffee();
        
    }
}