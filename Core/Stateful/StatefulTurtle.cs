using Core.Logic;

namespace Core.Stateful;

public class StatefulTurtle(ITurtle turtle)
{
    public State.State State { get; private set; } = Core.State.State.Initial();
    
    public static StatefulTurtle Create()
    {
        return new StatefulTurtle(new LogicTurtle());
    }
    
    public void PenUp()
    {
        State = turtle.PenUp(State);
    }

    public void PenDown()
    {
        State = turtle.PenDown(State);
    }

    public void MoveForward(int distance)
    {
        State = turtle.MoveForward(State, distance);
    }

    public void TurnLeft(int degrees)
    {
        State = turtle.TurnLeft(State, degrees);
    }

    public void TurnRight(int degrees)
    {
        State = turtle.TurnRight(State, degrees);
    }
}