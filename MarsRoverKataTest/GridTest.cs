using MarsRover;

namespace MarsRoverKataTest;

public class GridTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GridHasCorrectSize()
    {
        var grid = new Grid();
        var x = grid.GetSizeOfX();
        var y = grid.GetSizeOfY();

        Assert.AreEqual(10, x);
        Assert.AreEqual(10, y);
    }
    
    [Test]
    public void GridCanSetRoverPosition()
    {
        var grid = new Grid();
        var rover = new Rover(grid);
        var position = new Position(5,5);
        grid.SetRoverPosition(rover, position);
        
        Assert.IsTrue(grid.GetRoverPosition(rover).Equals(position));
    }
}