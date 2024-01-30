namespace Core;

public interface ITurtle
{
    public State.State PenUp(State.State state);
    public State.State PenDown(State.State state);
    public State.State MoveForward(State.State state, int distance);
    public State.State TurnLeft(State.State state, int degrees);
    public State.State TurnRight(State.State state, int degrees);
}