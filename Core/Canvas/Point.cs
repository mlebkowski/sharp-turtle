namespace Core.Canvas;

public record Point(int X, int Y)
{
    public override string ToString()
    {
        return $"{X}×{Y}";
    }
};