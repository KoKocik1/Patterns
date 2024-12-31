namespace Solid_O;

public class BetterFilter : Filter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecyfication<Product> spec)
    {
        foreach (var item in items)
            if (spec.isSatisfied(item))
                yield return item;
    }
}