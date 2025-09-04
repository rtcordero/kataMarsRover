using MarsRoverKataTest;

namespace MarsRover;

public class Rover
{
    private Grid grid;
    private Compass compass;

    public Rover(Grid grid, Compass compass)
    {
        this.grid = grid;
        this.compass = compass;
        this.grid.InitRoverOnGrid(this);
    }

    public Position GetPosition()
    {
        return grid.GetRoverPosition(this);
    }

    public Direction GetDirection()
    {
        return compass.GetDirection();
    }

    public void execute(Command[] commands)
    {
        commands.ToList().ForEach(command =>
        {
            if (command == Command.L)
            {
                compass.RotateLeft();
            }
        });
    }
}

public enum Command
{
    L
}