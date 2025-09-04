namespace MarsRoverKataTest;

public class Position
{
    private readonly int X;
    private readonly int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Position position)
        {
            return position.X == X && position.Y == Y;
        }

        return false;
    }
}