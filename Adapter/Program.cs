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

        var v = new Vector2i(1, 2);
        v[0] = 0;

        var vv = new Vector2i(3, 1);

        var result = v + vv;

        var vector3f = Vector3f.Create(2.2f, 3.3f, 4.4f);
    }
}