using Core.State;

namespace Core.Logger;

public class LoggingTurtle(ITurtle innerTurtle, ILogger logger) : ITurtle
{
    public State.State PenUp(State.State state)
    {
        if (state.Pen.IsDown()) logger.Write($"[{state.Position}] Pen up");

        return innerTurtle.PenUp(state);
    }

    public State.State PenDown(State.State state)
    {
        if (state.Pen.IsUp()) logger.Write($"[{state.Position}] Pen down");

        return innerTurtle.PenDown(state);
    }

    public State.State MoveForward(State.State state, int distance)
    {
        logger.Write(
            $"[{state.Position}] Move forward by {distance} units at an angle {state.Angle}"
        );

        return innerTurtle.MoveForward(state, distance);
    }

    public State.State TurnLeft(State.State state, int degrees)
    {
        logger.Write($"[{state.Position}] Turn left by {degrees} degrees");
        return innerTurtle.TurnLeft(state, degrees);
    }

    public State.State TurnRight(State.State state, int degrees)
    {
        logger.Write($"[{state.Position}] Turn right by {degrees} degrees");
        return innerTurtle.TurnRight(state, degrees);
    }
}