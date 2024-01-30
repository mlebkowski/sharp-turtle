namespace Core.BoundTurtle;

public record Rectangle
{
    private readonly Point _bottomLeft;
    private readonly Point _topRight;

    public Rectangle(Point alpha, Point bravo)
    {
        if (alpha.X == bravo.X || alpha.Y == bravo.Y)
            throw new Exception("A rectangle needs two dimensions");

        _bottomLeft = new Point(Math.Min(alpha.X, bravo.X), Math.Min(alpha.Y, bravo.Y));
        _topRight = new Point(Math.Max(alpha.X, bravo.X), Math.Max(alpha.Y, bravo.Y));
    }

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