using MarsRoverKataTest;

namespace MarsRover;

public class Compass
{
    private Direction direction;

    public Compass(Direction direction)
    {
        this.direction = direction;
    }

    public Direction GetDirection()
    {
        return this.direction;
    }

    public void RotateLeft()
    {
        if (direction == Direction.N)
        {
            direction = Direction.W;
        }
        else if (direction == Direction.W)
        {
            direction = Direction.S;
        }
        else if (direction == Direction.S)
        {
            direction = Direction.E;
        }
        else if (direction == Direction.E)
        {
            direction = Direction.N;
        }
    }

    public void RotateRight()
    {
        switch (direction)
        {
            case Direction.N:
                direction = Direction.E;
                break;
            case Direction.E:
                direction = Direction.S;
                break;
            case Direction.S:
                direction = Direction.W;
                break;
            case Direction.W:
                direction = Direction.N;
                break;
        }
    }
}