using NUnit.Framework;

namespace Core.State;

[TestFixture]
[TestOf(typeof(Angle))]
public class AngleTest
{
    [TestCaseSource(nameof(DataProvider))]
    public void Creating(int input, int expected)
    {
        Assert.That(new Angle(input).Degrees, Is.EqualTo(expected));
    }

    [Test]
    public void Adding()
    {
        Assert.That(new Angle(30).Add(new Angle(30)), Is.EqualTo(new Angle(60)));
    }

    [Test]
    public void Subtracting()
    {
        Assert.That(new Angle(30).Sub(new Angle(30)), Is.EqualTo(new Angle(0)));
    }

    internal static object[] DataProvider =
    [
        new object[] { 0, 0 },
        new object[] { 10, 10 },
        new object[] { -10, 350 },
        new object[] { 360, 0 },
        new object[] { 720, 0 },
        new object[] { 730, 10 }
    ];
}