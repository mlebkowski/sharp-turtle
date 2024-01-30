using NUnit.Framework;

namespace Core.BoundTurtle;

[TestFixture]
[TestOf(typeof(BoundTurtle))]
public class BoundTurtleTest
{
    [SetUp]
    public void SetUp()
    {
        _scenario = new BoundTurtleScenario();
    }

    private BoundTurtleScenario _scenario;

    [Test]
    public void MovesWithinBounds()
    {
        _scenario
            .GivenBoundingBox(new Rectangle(new Point(-50, -50), new Point(50, 50)))
            .WhenTurtleMoves(30)
            .ThenThePositionIs(new State.Point(30, 0));
    }

    [Test]
    public void DoesNotMoveOutOfBounds()
    {
        _scenario
            .GivenBoundingBox(new Rectangle(new Point(-50, -50), new Point(50, 50)))
            .WhenTurtleMoves(100)
            .ThenOutOfBoundsExceptionIsExpected("Moved to 100×0 outside of Rectangle<-50×-50, 50×50>");
    }
}