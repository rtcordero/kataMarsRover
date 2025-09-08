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
                    rotateLeft();
                    break;
                case Command.R:
                    rotateRight();
                    break;
                case Command.M:
                    move();
                    break;
            }
        });
    }

    private void move()
    {
        switch (compass.GetDirection())
        {
            case Direction.N:
                grid.increaseY(this);
                break;
            case Direction.E:
                grid.increaseX(this);
                break;
            case Direction.S:
                // To be implemented
                break;
            case Direction.W:
                grid.decreaseX(this);
                break;
        }
        {
            
        }
    }

    private void rotateRight()
    {
        compass.RotateRight();
    }

    private void rotateLeft()
    {
        compass.RotateLeft();
    }
}