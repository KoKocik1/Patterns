namespace Solid_O
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = [apple, tree, house];

            var bf = new BetterFilter();
            foreach (var product in bf.Filter(products, new ColorSpecyfication(Color.Green)))
            {
                Console.WriteLine($" - {product.Name} is green");
            }

            foreach (var product in bf.Filter(products, new AndSpecyfication<Product>(
                         new ColorSpecyfication(Color.Green),
                         new SizeSpecyfication(Size.Large)
                     )))
            {
                Console.WriteLine($" - {product.Name} is green and large");
            }
        }
    }
}