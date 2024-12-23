namespace Builder.Builders;

public enum CarType
{
    Sedan,
    CrossOver
}

public class Car
{
    public CarType Type;
    public int WheelSize;
    
    public override string ToString()
    {
        return $"Car type: {Type}, wheel size: {WheelSize}";
    }
}
