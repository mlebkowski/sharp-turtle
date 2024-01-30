namespace Core.State;

public readonly struct Angle(int degrees)
{
    public readonly int Degrees = (degrees % 360 + 360) % 360;

    public double Radian => Degrees * Math.PI / 180;

    public static Angle Start()
    {
        return new Angle(0);
    }

    public Angle Add(Angle other)
    {
        return new Angle(Degrees + other.Degrees);
    }

    public Angle Sub(Angle other)
    {
        return new Angle(Degrees - other.Degrees);
    }


    public override string ToString()
    {
        return $"{Degrees} degrees";
    }
}