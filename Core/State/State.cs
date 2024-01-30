namespace Core.State;

public record State(Pen Pen, Angle Angle, Point Position)
{
    public static State Initial()
    {
        return new State(Pen.Down, Angle.Start(), Point.Start());
    }
}