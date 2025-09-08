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

    public String Execute(Command[] commands)
    {
        commands.ToList().ForEach(command =>
        {
            switch (command)
            {
                case Command.L:
                    RotateLeft();
                    break;
                case Command.R:
                    RotateRight();
                    break;
                case Command.M:
                    Move();
                    break;
            }
        });
        return GetFinishExecutingResponse();
    }

    private string GetFinishExecutingResponse()
    {
        return $"{GetPosition().GetXValue()}:{GetPosition().GetYValue()}:{GetDirection()}";
    }

    private void Move()
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
                grid.decreaseY(this);
                break;
            case Direction.W:
                grid.decreaseX(this);
                break;
        }
    }

    private void RotateRight()
    {
        compass.RotateRight();
    }

    private void RotateLeft()
    {
        compass.RotateLeft();
    }
}