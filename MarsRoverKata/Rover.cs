using MarsRoverKataTest;

namespace MarsRover;

public class Rover
{
    private Grid grid;

    public Rover(Grid grid)
    {
        this.grid = grid;
        this.grid.SetRoverPosition(this, new Position(new Coordinate(0), new Coordinate(0)));
    }

    public Position GetPosition()
    {
        return grid.GetRoverPosition(this);
    }
}