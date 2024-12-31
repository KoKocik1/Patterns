using Adapter.Interface;

namespace Adapter.Model;

public class VectorOfInt<D> : Vector<int,D> 
    where D : IInteger, new()
{
    public VectorOfInt()
    {
    }

    public VectorOfInt(params int[] values) : base(values)
    {
    }
    
    public static VectorOfInt<D> operator +(VectorOfInt<D> v1, VectorOfInt<D> v2)
    {
        var result = new VectorOfInt<D>();
        for (int i = 0; i < new D().Value; i++)
        {
            result[i] = v1[i] + v2[i];
        }

        return result;
    }
}