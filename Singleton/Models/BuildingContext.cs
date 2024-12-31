namespace Singleton.Models;

public sealed class BuildingContext : IDisposable
{
    private static readonly Stack<BuildingContext> stack = new();

    public int WallHeight;
    public int WallThickness = 300; // etc.

    static BuildingContext()
    {
        // ensure there's at least one state
        stack.Push(new BuildingContext(0));
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        stack.Push(this);
    }

    public static BuildingContext Current => stack.Peek();

    public void Dispose()
    {
        // not strictly necessary
        if (stack.Count > 1)
            stack.Pop();
    }
}