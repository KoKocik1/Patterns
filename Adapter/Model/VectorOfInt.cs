using Adapter.Interface;

namespace Adapter.Model;

public class VectorOfInt<TSelf, D> : Vector<TSelf, int, D>
    where D : IInteger, new()
    where TSelf : VectorOfInt<TSelf, D>, new()
{
    public VectorOfInt()
    {
    }

    public VectorOfInt(params int[] values) : base(values)
    {
    }

    public static VectorOfInt<TSelf, D> operator +(VectorOfInt<TSelf, D> v1, VectorOfInt<TSelf, D> v2)
    {
        var result = new VectorOfInt<TSelf, D>();
        for (var i = 0; i < new D().Value; i++) result[i] = v1[i] + v2[i];

        return result;
    }
}