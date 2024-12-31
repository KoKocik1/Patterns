namespace Solid_L;

public class Square : Rectangle
{
    public override int Width // override instead of new
    {
        set => base.Width = base.Height = value;
    }

    public override int Height // override instead of new
    {
        set => base.Width = base.Height = value;
    }
}