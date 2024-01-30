namespace Core.Canvas;

public record Line(Point Start, Point End) : IEquatable<string>
{
    public virtual bool Equals(string? other)
    {
        if (ReferenceEquals(null, other)) return false;
        return $"{this}" == other;
    }

    public override string ToString()
    {
        return $"{Start} → {End}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }
}