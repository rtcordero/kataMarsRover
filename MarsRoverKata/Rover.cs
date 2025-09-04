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
            switch (command)
            {
                case Command.L:
                    compass.RotateLeft();
                    break;
                case Command.R:
                    compass.RotateRight();
                    break;
            }
        });
    }
}