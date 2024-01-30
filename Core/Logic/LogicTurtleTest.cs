using Core.State;
using NUnit.Framework;

namespace Core.Logic;

[TestFixture]
[TestOf(typeof(LogicTurtle))]
public class LogicTurtleTest
{
    [TestCaseSource(nameof(DataProvider))]
    public void MoveForward(int distance, int angle, Point position)
    {
        new LogicTurtleScenario()
            .GivenTurtleIsFacing(angle)
            .WhenItMovesForward(distance)
            .ThenItArrivesAt(position);
    }

    internal static object[] DataProvider =
    [
        new object[] { 10, 0, new Point(10, 0) },
        new object[] { 10, 90, new Point(0, -10) },
        new object[] { 10, 180, new Point(-10, 0) },
        new object[] { 10, 270, new Point(0, 10) },
        new object[] { 10, -45, new Point(7, 7) },
        new object[] { 10, -30, new Point(9, 5) },
        new object[] { 10, -30 - 90, new Point(-5, 9) },
        new object[] { 10, -30 - 180, new Point(-9, -5) },
        new object[] { 10, -30 - 270, new Point(5, -9) },
    ];
}