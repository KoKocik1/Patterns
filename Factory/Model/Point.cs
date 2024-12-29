namespace Factory.Model;

public class Point
{
    private double x, y;
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
    public override string ToString()
    {
        return $"{nameof(x)}: {x.ToString("0.00")}, {nameof(y)}: {y.ToString("0.00")}";
    }
}