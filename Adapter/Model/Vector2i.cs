using Adapter.Utils;

namespace Adapter.Model;

public class Vector2i : VectorOfInt<Dimensions.Two>
{
    public Vector2i()
    {
    }

    public Vector2i(params int[] values) : base(values)
    {
    }
}