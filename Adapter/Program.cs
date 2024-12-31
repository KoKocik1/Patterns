
using Adapter.Model;
using Adapter.Utils;

class Program
{
    private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
    {
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 6, 6)
    };
    
    static void Main(string[] args)
    {
        DrawUtils.Draw(vectorObjects);
        DrawUtils.Draw(vectorObjects);
    }
}