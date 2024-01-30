using Core.Logic;
using Core.Stateful;
using NUnit.Framework;

namespace Core.Canvas;

public class CanvasTurtleScenario
{
    private readonly CanvasSpy _canvas = new();
    private readonly StatefulTurtle _turtle;

    public CanvasTurtleScenario()
    {
        _turtle = new StatefulTurtle(new CanvasTurtle(_canvas, new LogicTurtle()));
    }

    public CanvasTurtleScenario WhenOddSidesOfRectangleAreDrawn(int sideLength)
    {
        _turtle.MoveForward(sideLength);
        _turtle.TurnRight(90);
        _turtle.PenUp();
        
        _turtle.MoveForward(sideLength);
        _turtle.TurnRight(90);
        _turtle.PenDown();
        
        _turtle.MoveForward(sideLength);
        _turtle.TurnRight(90);
        _turtle.PenUp();
        
        _turtle.MoveForward(sideLength);
        _turtle.TurnRight(90);
        _turtle.PenDown();

        return this;
    }

    public CanvasTurtleScenario ThenCanvasLinesAreExpected(params string[] lines)
    {
        Assert.That(_canvas.Lines, Is.EqualTo(lines));
        return this;
    }
}