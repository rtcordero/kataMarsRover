using MarsRover;

namespace MarsRoverKataTest;

public class RoverTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RoverInitPosition()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));
        var initialPosition = new Position(new Coordinate(0), new Coordinate(0));

        Assert.AreEqual(initialPosition, rover.GetPosition());
    }

    [Test]
    public void RoverPositionOnTheGrid()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));
        var initialPosition = new Position(new Coordinate(0), new Coordinate(0));

        Assert.IsTrue(grid.GetRoverPosition(rover).Equals(initialPosition));
    }

    [Test]
    public void RoverInitOnNorthPosition()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        Assert.AreEqual(Direction.N, rover.GetDirection());
    }

    [Test]
    public void RoverCanRotateToLeft()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));
        
        rover.execute([Command.L]);
        
        Assert.AreEqual(Direction.W, rover.GetDirection());
    }

    [Test]
    public void RoverCanRotateToLeftTwice()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.execute([Command.L, Command.L]);

        Assert.AreEqual(Direction.S, rover.GetDirection());
    }
    
    [Test]
    public void RoverCanRotateToRight()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.execute([Command.R]);

        Assert.AreEqual(Direction.E, rover.GetDirection());
    }
}