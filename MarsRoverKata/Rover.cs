using System.Runtime.Intrinsics.X86;
using MarsRoverKataTest;

namespace MarsRover;

public class Rover
{
    private readonly Position position;
    public Rover(Grid grid)
    {
        position = new Position(0,0);
    }

    public Position GetPosition()
    {
        return position;
    }
}