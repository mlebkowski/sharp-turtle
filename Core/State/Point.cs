namespace Core.State;

public readonly struct Point(int x, int y)
{
    public readonly int X = x;
    public readonly int Y = y;

    public static Point Start()
    {
        return new Point(x: 0, y: 0);
    }
    
    public Point Add(Point other)
    {
        return new Point(x: X + other.X, y: Y + other.Y);
    }

    public override string ToString()
    {
        return $"{X}×{Y}";
    }
}