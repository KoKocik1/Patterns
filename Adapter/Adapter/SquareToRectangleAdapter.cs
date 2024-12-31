using Adapter.Interface;
using Adapter.Model;

namespace Adapter.Adapter;

public class SquareToRectangleAdapter : IRectangle
{
    private Square _square;
    public SquareToRectangleAdapter(Square square)
    {
        _square= square;
    }
    public int Width => _square.Side;
    public int Height => _square.Side;
}