using Core.State;
using NUnit.Framework;
using static Core.State.State;

namespace Core.Logic;

public class LogicTurtleScenario
{
    private State.State _state = Initial();

    public LogicTurtleScenario GivenTurtleIsFacing(int angle)
    {
        _state = _state with { Angle = new Angle(angle) };
        return this;
    }

    public LogicTurtleScenario WhenItMovesForward(int distance)
    {
        var sut = new LogicTurtle();
        _state = sut.MoveForward(_state, distance);
        return this;
    }

    public LogicTurtleScenario ThenItArrivesAt(Point position)
    {
        Assert.That(_state.Position, Is.EqualTo(position));
        return this;
    }
}