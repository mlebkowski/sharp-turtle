namespace Core.BoundTurtle;

public class BoundTurtle(ITurtle innerTurtle, Rectangle boundingBox): ITurtle
{
    public State.State PenUp(State.State state)
    {
        return innerTurtle.PenUp(state);
    }

    public State.State PenDown(State.State state)
    {
        return innerTurtle.PenDown(state);
    }

    public State.State MoveForward(State.State state, int distance)
    {
        var result = innerTurtle.MoveForward(state, distance);
        OutOfBoundsException.WhenMovedOutsideTheBoundingBox(result.Position, boundingBox);
        return result;
    }

    public State.State TurnLeft(State.State state, int degrees)
    {
        return innerTurtle.TurnLeft(state, degrees);
    }

    public State.State TurnRight(State.State state, int degrees)
    {
        return innerTurtle.TurnRight(state, degrees);
    }
}