using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid_O
{
    public class ColorSpecyfication : ISpecyfication<Product>
    {
        private Color _color;
        public ColorSpecyfication(Color color)
        {
            _color = color;
        }
        public bool isSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
    public class SizeSpecyfication : ISpecyfication<Product>
    {
        private Size _size;
        public SizeSpecyfication(Size size)
        {
            _size = size;
        }
        public bool isSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }
    public class AndSpecyfication<T> : ISpecyfication<T>
    {
        private ISpecyfication<T> _first, _second;
        public AndSpecyfication(ISpecyfication<T> first, ISpecyfication<T> second)
        {
            _first = first;
            _second = second;
        }
        public bool isSatisfied(T t)
        {
            return _first.isSatisfied(t) && _second.isSatisfied(t);
        }
    }
}