using Factory.Interface;

namespace Factory.Factory;

public class HotDrinkMashine
{
    public enum AvailableDrink
    {
        Coffee, Tea
    }
    
    private Dictionary<AvailableDrink, IHotDrinkFactory> factories 
        = new Dictionary<AvailableDrink, IHotDrinkFactory>();

    public HotDrinkMashine()
    {
        foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        {
            var factory = (IHotDrinkFactory)Activator.CreateInstance(
                Type.GetType("Factory.Factory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory")
            );
            factories.Add(drink, factory);
        }
    }
    
    public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    {
        return factories[drink].Prepare(amount);
    }
}