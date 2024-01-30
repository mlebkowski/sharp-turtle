namespace Core.Canvas;

public class CanvasSpy : ICanvas
{
    public readonly List<Line> Lines = [];

    public void DrawLine(Line line)
    {
        Lines.Add(line);
    }
}