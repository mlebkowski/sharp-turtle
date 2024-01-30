namespace Core.BoundTurtle;

public record Rectangle
{
    public Rectangle(Point bottomLeft, Point topRight)
    {
        _bottomLeft = bottomLeft;
        _topRight = topRight;
        if (bottomLeft.X == topRight.X || bottomLeft.Y == topRight.Y)
        {
            throw new Exception("A rectangle needs two dimensions");
        }
    }

    private readonly Point _bottomLeft;
    private readonly Point _topRight;

    public bool Contains(Point point)
    {
        return _bottomLeft.X <= point.X && point.X <= _topRight.X
                                        && _bottomLeft.Y <= point.Y && point.Y <= _topRight.Y;
    }

    public override string ToString()
    {
        return $"Rectangle<{_bottomLeft}, {_topRight}>";
    }
}