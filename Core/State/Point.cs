namespace Core.State;

public record Point(int X, int Y)
{
    public static Point Start()
    {
        return new Point(X: 0, Y: 0);
    }
    
    public Point Add(Point other)
    {
        return new Point(X: X + other.X, Y: Y + other.Y);
    }

    public override string ToString()
    {
        return $"{X}×{Y}";
    }
}