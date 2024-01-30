using Core.State;
using NUnit.Framework;

namespace Core.Stateful;

[TestFixture]
[TestOf(typeof(StatefulTurtle))]
public class StatefulTurtleTest
{
    [SetUp]
    public void SetUp()
    {
        _scenario = new StatefulTurtleScenario();
    }

    private StatefulTurtleScenario _scenario;

    [Test]
    public void Angles()
    {
        _scenario
            .WhenTurtleTurnsLeft(90)
            .ThenTheAngleIs(new Angle(270));
    }

    [Test]
    public void Moves()
    {
        _scenario
            .WhenTurtleTurnsLeft(90)
            .AndMovesForward(100)
            .ThenThePositionIs(new Point(0, 100));
    }
}