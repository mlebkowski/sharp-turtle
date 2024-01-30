using Core.BoundTurtle;
using NUnit.Framework;

namespace Core.BoundTurtle;

[TestFixture]
[TestOf(typeof(BoundTurtle))]
public class BoundTurtleTest
{
    private BoundTurtleScenario _scenario;

    [Test]
    public void MovesWithinBounds()
    {
        _scenario
            .GivenBoundingBox(new Rectangle(new Point(-50, -50), new Point(50, 50)))
            .WhenTurtleMoves(distance: 30)
            .ThenThePositionIs(new State.Point(X: 30, Y: 0));
    }

    [Test]
    public void DoesNotMoveOutOfBounds()
    {
        _scenario
            .GivenBoundingBox(new Rectangle(new Point(-50, -50), new Point(50, 50)))
            .WhenTurtleMoves(distance: 100)
            .ThenOutOfBoundsExceptionIsExpected("Moved to 100×0 outside of Rectangle<-50×-50, 50×50>");
    }

    [SetUp]
    public void SetUp() => _scenario = new BoundTurtleScenario();
}