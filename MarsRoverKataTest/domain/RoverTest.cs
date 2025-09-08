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
        
        rover.Execute([Command.L]);
        
        Assert.AreEqual(Direction.W, rover.GetDirection());
    }

    [Test]
    public void RoverCanRotateToLeftTwice()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.Execute([Command.L, Command.L]);

        Assert.AreEqual(Direction.S, rover.GetDirection());
    }
    
    [Test]
    public void RoverCanRotateToRight()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.Execute([Command.R]);

        Assert.AreEqual(Direction.E, rover.GetDirection());
    }

    [Test]
    public void RoverCanRotateToRightTwice()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.Execute([Command.R, Command.R]);

        Assert.AreEqual(Direction.S, rover.GetDirection());
    }
    
    [Test]
    public void RoverCanMoveToFrontWhenStartOnNorth()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.Execute([Command.M]);

        Assert.AreEqual(new Position(new Coordinate(0), new Coordinate(1)), rover.GetPosition());
    }
    
    [Test]
    public void RoverCanMoveToFrontWhenStartOnEast()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.E));

        rover.Execute([Command.M]);

        Assert.AreEqual(new Position(new Coordinate(1), new Coordinate(0)), rover.GetPosition());
    }
    
    [Test]
    public void RoverCanMoveToFrontWhenDirectionIsWest()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.E));

        rover.Execute([Command.M, Command.L, Command.L, Command.M]);

        Assert.AreEqual(new Position(new Coordinate(0), new Coordinate(0)), rover.GetPosition());
    }
    
    [Test]
    public void RoverCanMoveToFrontWhenDirectionIsSouth()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        rover.Execute([Command.M, Command.L, Command.L, Command.M]);

        Assert.AreEqual(new Position(new Coordinate(0), new Coordinate(0)), rover.GetPosition());
    }
    
    [Test]
    public void RoverReportFinalPositionAfterFinishingCommands()
    {
        var grid = new Grid();
        var rover = new Rover(grid, new Compass(Direction.N));

        var result = rover.Execute([Command.M, Command.R, Command.M, Command.R, Command.M, Command.R, Command.M, Command.R]);

        Assert.AreEqual(result, "0:0:N");
        Assert.AreEqual(new Position(new Coordinate(0), new Coordinate(0)), rover.GetPosition());
        Assert.AreEqual(Direction.N, rover.GetDirection());
    }
    
    // TODO Add test to check that rover does not move out of the grid
    // TODO Add test when there are obstacles on the grid
}