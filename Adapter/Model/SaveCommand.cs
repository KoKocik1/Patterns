using Adapter.Interface;

namespace Adapter.Model;

public class SaveCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Saving a file");
    }
}