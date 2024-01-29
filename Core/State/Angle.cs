namespace Core.State;

public readonly struct Angle(int degrees)
{
    public readonly int Degrees = (degrees % 360 + 360) % 360;

    public Angle Add(Angle other)
    {
        return new Angle(Degrees + other.Degrees);
    }

    public Angle Sub(Angle other)
    {
        return new Angle(Degrees - other.Degrees);
    }
}