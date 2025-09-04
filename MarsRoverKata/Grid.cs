using MarsRoverKataTest;

namespace MarsRover;

public class Grid
{
    private const int X = 10;
    private const int Y = 10;
    private readonly Dictionary<Rover, Position> roverPositions = new();

    public int GetSizeOfX()
    {
        return X;
    }

    public int GetSizeOfY()
    {
        return Y;
    }

    public void SetRoverPosition(Rover rover, Position position)
    {
        roverPositions[rover] = position;
    }

    public Position GetRoverPosition(Rover rover)
    {
        return roverPositions[rover];
    }
}