namespace Factory.Interface;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}