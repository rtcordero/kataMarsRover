using MarsRoverKataTest;

namespace MarsRover;

public class Rover
{
    private readonly Position position;

    public Rover(Grid grid)
    {
        position = new Position(0, 0);
        grid.SetRoverPosition(this, position);
    }

    public Position GetPosition()
    {
        return position;
    }
}