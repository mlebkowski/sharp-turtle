namespace Core;

public class TurtleSpy: ITurtle
{
    public readonly Stack<string> Calls = [];
    
    public State.State PenUp(State.State state)
    {
        Calls.Push($"{nameof(ITurtle.PenUp)}");
        return state;
    }

    public State.State PenDown(State.State state)
    {
        Calls.Push($"{nameof(ITurtle.PenDown)}");
        return state;
    }

    public State.State MoveForward(State.State state, int distance)
    {
        Calls.Push($"{nameof(ITurtle.MoveForward)} {distance}");
        return state;
    }

    public State.State TurnLeft(State.State state, int degrees)
    {
        Calls.Push($"{nameof(ITurtle.TurnLeft)} {degrees}");
        return state;
    }

    public State.State TurnRight(State.State state, int degrees)
    {
        Calls.Push($"{nameof(ITurtle.TurnRight)} {degrees}");
        return state;
    }
}