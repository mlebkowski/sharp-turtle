namespace Core.Logger;

public class LoggerSpy : ILogger
{
    public readonly List<string> Messages = [];
    
    public void Write(string message)
    {
        Messages.Add(message);
    }
}