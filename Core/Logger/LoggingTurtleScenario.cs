using NUnit.Framework;

namespace Core.Logger;

public class LoggingTurtleScenario
{
    private readonly LoggerSpy _logger = new();
    private readonly State.State _state = State.State.Initial();
    private readonly TurtleSpy _turtle = new();

    public LoggingTurtleScenario WhenTurtleTurnsLeft(int degrees)
    {
        var sut = new LoggingTurtle(_turtle, _logger);
        sut.TurnLeft(_state, degrees);
        return this;
    }

    public LoggingTurtleScenario WhenTurtleTurnsRight(int degrees)
    {
        var sut = new LoggingTurtle(_turtle, _logger);
        sut.TurnRight(_state, degrees);
        return this;
    }

    public LoggingTurtleScenario WhenTurtleMovesForward(int distance)
    {
        var sut = new LoggingTurtle(_turtle, _logger);
        sut.MoveForward(_state, distance);
        return this;
    }

    public LoggingTurtleScenario ThenMessageIsLogged(params string[] expected)
    {
        Assert.That(_logger.Messages, Is.EqualTo(expected));
        return this;
    }

    public LoggingTurtleScenario AndTurtleReceivedInstruction(string expected)
    {
        Assert.That(_turtle.Calls.Pop(), Is.EqualTo(expected));
        return this;
    }
}