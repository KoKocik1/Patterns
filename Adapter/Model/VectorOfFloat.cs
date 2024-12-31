using Adapter.Interface;

namespace Adapter.Model;

public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
    where D : IInteger, new()
    where TSelf : VectorOfFloat<TSelf, D>, new()
{
    public VectorOfFloat()
    {
    }

    public VectorOfFloat(params float[] values) : base(values)
    {
    }

    public static VectorOfFloat<TSelf, D> operator +(VectorOfFloat<TSelf, D> v1, VectorOfFloat<TSelf, D> v2)
    {
        var result = new TSelf();
        for (int i = 0; i < new D().Value; i++)
        {
            result[i] = v1[i] + v2[i];
        }

        return result;
    }
}