using Core.State;

namespace Core.Canvas;

public class CanvasTurtle(ICanvas canvas, ITurtle innerTurtle): ITurtle
{
    public State.State PenUp(State.State state) => innerTurtle.PenUp(state);

    public State.State PenDown(State.State state) => innerTurtle.PenDown(state);

    public State.State MoveForward(State.State state, int distance)
    {
        var start = state.Position;
        var result = innerTurtle.MoveForward(state, distance);
        var end = result.Position;

        if (state.Pen.IsDown())
        {
            var line = new Line(
                new Point(start.X, start.Y * -1),
                new Point(end.X, end.Y * -1)
            );
            canvas.DrawLine(line);
        }

        return result;
    }

    public State.State TurnLeft(State.State state, int degrees) => innerTurtle.TurnLeft(state, degrees);

    public State.State TurnRight(State.State state, int degrees) => innerTurtle.TurnRight(state, degrees);
}