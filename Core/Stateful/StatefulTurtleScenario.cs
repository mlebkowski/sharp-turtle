using Core.State;
using NUnit.Framework;

namespace Core.Stateful;

public class StatefulTurtleScenario
{
    private readonly StatefulTurtle _turtle = StatefulTurtle.Create();

    public StatefulTurtleScenario WhenTurtleTurnsLeft(int angle)
    {
        _turtle.TurnLeft(angle);
        return this;
    }

    public StatefulTurtleScenario AndMovesForward(int distance)
    {
        _turtle.MoveForward(distance);
        return this;
    }

    public StatefulTurtleScenario ThenTheAngleIs(Angle angle)
    {
        Assert.That(_turtle.State.Angle, Is.EqualTo(angle));
        return this;
    }

    public StatefulTurtleScenario ThenThePositionIs(Point position)
    {
        Assert.That(_turtle.State.Position, Is.EqualTo(position));
        return this;
    }
}