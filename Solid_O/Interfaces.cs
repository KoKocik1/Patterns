using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid_O
{
    public interface ISpecyfication<T>
    {
        bool isSatisfied(T t);
    }
    public interface Filter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecyfication<T> spec);
    }
}