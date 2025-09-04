using MarsRoverKataTest;

namespace MarsRover;

public class Rover
{
    private Grid grid;

    public Rover(Grid grid)
    {
        this.grid = grid;
        this.grid.InitRoverOnGrid(this);
    }

    public Position GetPosition()
    {
        return grid.GetRoverPosition(this);
    }
}