using Adapter.Interface;

namespace Adapter.Model;

public class OpenCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Opening a file");
    }
}