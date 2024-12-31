using Adapter.Utils;

namespace Adapter.Model;

public class Vector2i : VectorOfInt<Vector2i, Dimensions.Two>
{
    public Vector2i()
    {
    }

    public Vector2i(params int[] values) : base(values)
    {
    }
}