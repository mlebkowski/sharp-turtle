using NUnit.Framework;

namespace Core.State;

[TestFixture]
[TestOf(typeof(Point))]
public class PointTest
{
    [Test]
    public void Add()
    {
        Assert.That(
            new Point(1, 2).Add(new Point(2, 3)),
            Is.EqualTo(new Point(3, 5))
        );

        Assert.That(
            Point.Start().Add(new Point(2, -3)),
            Is.EqualTo(new Point(2, -3))
        );
    }
}