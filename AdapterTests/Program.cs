using Adapter.Adapter;
using Adapter.Model;
using NUnit.Framework;

[TestFixture]
public class SingletonTests
{
    [Test]
    public void IsSingletonTest()
    {
        var square = new Square(5);
        var rectangle = new SquareToRectangleAdapter(square);
        Assert.That(rectangle.Width, Is.EqualTo(5));
        Assert.That(rectangle.Height, Is.EqualTo(5));
    }
}