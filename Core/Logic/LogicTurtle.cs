using Core.State;

namespace Core.Logic;

public class LogicTurtle : ITurtle
{
    public State.State PenUp(State.State state)
    {
        return state with { Pen = Pen.Up };
    }

    public State.State PenDown(State.State state)
    {
        return state with { Pen = Pen.Down };
    }

    public State.State MoveForward(State.State state, int distance)
    {
        var angle = state.Angle.Radian * -1;
        var xFactor = Math.Cos(angle);
        var xDistance = (int)Math.Round(distance * xFactor);
        var yFactor = Math.Sin(angle);
        var yDistance = (int)Math.Round(distance * yFactor);
        var vector = new Point(xDistance, yDistance);

        return state with { Position = state.Position.Add(vector) };
    }

    public State.State TurnLeft(State.State state, int degrees)
    {
        return state with { Angle = state.Angle.Sub(new Angle(degrees)) };
    }

    public State.State TurnRight(State.State state, int degrees)
    {
        return state with { Angle = state.Angle.Add(new Angle(degrees)) };
    }
}