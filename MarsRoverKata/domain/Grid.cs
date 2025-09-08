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
    
    public void InitRoverOnGrid(Rover rover)
    {
        roverPositions[rover] = new Position(new Coordinate(0), new Coordinate(0));
    }

    public void SetRoverPosition(Rover rover, Position position)
    {
        roverPositions[rover] = position;
    }

    public Position GetRoverPosition(Rover rover)
    {
        return roverPositions[rover];
    }

    public void IncreaseX(Rover rover)
    {
        roverPositions[rover].IncreaseX();
    }

    public void DecreaseX(Rover rover)
    {
        roverPositions[rover].DecreaseX();
    }

    public void IncreaseY(Rover rover)
    {
        roverPositions[rover].IncreaseY();
    }

    public void DecreaseY(Rover rover)
    {
        roverPositions[rover].DecreaseY();
    }
}