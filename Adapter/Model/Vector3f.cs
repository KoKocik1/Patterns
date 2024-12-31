using Adapter.Utils;

namespace Adapter.Model;

public class Vector3f : VectorOfFloat<Vector3f, Dimensions.Three>
{
    public Vector3f()
    {
    }

    public Vector3f(params float[] values) : base(values)
    {
    }
}