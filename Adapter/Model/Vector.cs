using Adapter.Interface;

namespace Adapter.Model;

public class Vector<TSelf, T, D>
    where D : IInteger, new()
    where TSelf : Vector<TSelf, T, D>, new()
{
    protected T[] data;

    public Vector()
    {
        data = new T[new D().Value];
    }

    public Vector(params T[] values)
    {
        var requiredLength = new D().Value;
        data = new T[requiredLength];

        var providedLength = values.Length;
        var actLength = Math.Min(requiredLength, providedLength);

        for (int i = 0; i < actLength; i++)
        {
            data[i] = values[i];
        }
    }

    public static TSelf Create(params T[] values)
    {
        var result = new TSelf();
        var requiredLength = new D().Value;
        result.data = new T[requiredLength];

        var providedLength = values.Length;
        var actLength = Math.Min(requiredLength, providedLength);

        for (int i = 0; i < actLength; i++)
        {
            result.data[i] = values[i];
        }

        return result;
    }

    public T this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }

    public T X
    {
        get => data[0];
        set => data[0] = value;
    }
}