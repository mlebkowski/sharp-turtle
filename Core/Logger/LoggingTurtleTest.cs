using NUnit.Framework;

namespace Core.Logger;

[TestFixture]
[TestOf(typeof(LoggingTurtle))]
public class LoggingTurtleTest
{
    [SetUp]
    public void SetUp()
    {
        _scenario = new LoggingTurtleScenario();
    }

    private LoggingTurtleScenario _scenario = new();

    [Test]
    public void TurtleTurnsLeft()
    {
        _scenario
            .WhenTurtleTurnsLeft(90)
            .ThenMessageIsLogged("[0×0] Turn left by 90 degrees")
            .AndTurtleReceivedInstruction("TurnLeft 90");
    }

    [Test]
    public void TurtleTurnsRight()
    {
        _scenario
            .WhenTurtleTurnsRight(60)
            .ThenMessageIsLogged("[0×0] Turn right by 60 degrees")
            .AndTurtleReceivedInstruction("TurnRight 60");
    }

    [Test]
    public void TurtleMovesForward()
    {
        _scenario
            .WhenTurtleMovesForward(10)
            .ThenMessageIsLogged("[0×0] Move forward by 10 units at an angle 0 degrees")
            .AndTurtleReceivedInstruction("MoveForward 10");
    }
}