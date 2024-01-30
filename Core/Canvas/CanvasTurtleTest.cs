using Core.Canvas;
using NUnit.Framework;

namespace Core.Canvas;

[TestFixture]
[TestOf(typeof(CanvasTurtle))]
public class CanvasTurtleTest
{

    [Test]
    public void Test()
    {
        new CanvasTurtleScenario()
            .WhenOddSidesOfRectangleAreDrawn(100)
            .ThenCanvasLinesAreExpected(
                "0×0 → 100×0",
                "100×100 → 0×100"
            );
    }
}