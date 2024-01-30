namespace Core.State;

public record Point(int X, int Y)
{
    public static Point Start()
    {
        return new Point(0, 0);
    }

    public Point Add(Point other)
    {
        return new Point(X + other.X, Y + other.Y);
    }

    public override string ToString()
    {
        return $"{X}×{Y}";
    }
}