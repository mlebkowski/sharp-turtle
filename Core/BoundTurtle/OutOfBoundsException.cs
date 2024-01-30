namespace Core.BoundTurtle;

public class OutOfBoundsException(string message) : Exception(message), ITurtleException
{
    public static void WhenMovedOutsideTheBoundingBox(State.Point position, Rectangle boundingBox)
    {
        if (boundingBox.Contains(new Point(position.X, position.Y)))
        {
            return;
        }

        throw new OutOfBoundsException($"Moved to {position} outside of {boundingBox}");
    }
}