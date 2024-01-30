using Core.Logic;
using NUnit.Framework;

namespace Core.BoundTurtle;

public class BoundTurtleScenario
{
    private State.State? _actual;
    private Rectangle _boundingBox = new(new Point(0, 0), new Point(1, 1));
    private Exception? _exception;

    public BoundTurtleScenario GivenBoundingBox(Rectangle boundingBox)
    {
        _boundingBox = boundingBox;
        return this;
    }

    public BoundTurtleScenario WhenTurtleMoves(int distance)
    {
        var sut = new BoundTurtle(new LogicTurtle(), _boundingBox);
        try
        {
            _exception = null;
            _actual = sut.MoveForward(State.State.Initial(), distance);
        }
        catch (Exception e)
        {
            _exception = e;
            _actual = null;
        }

        return this;
    }

    public BoundTurtleScenario ThenThePositionIs(State.Point expected)
    {
        Assert.That(_actual, Is.Not.Null);
        Assert.That(_actual?.Position, Is.EqualTo(expected));
        return this;
    }

    public BoundTurtleScenario ThenOutOfBoundsExceptionIsExpected(string message)
    {
        Assert.That(_exception, Is.Not.Null);
        Assert.That(_exception?.Message, Is.EqualTo(message));
        return this;
    }
}