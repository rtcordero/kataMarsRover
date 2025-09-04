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
        var rover = new Rover(grid);
        var initialPosition = new Position(0,0);
        
        Assert.AreEqual(initialPosition, rover.GetPosition());
    }
}