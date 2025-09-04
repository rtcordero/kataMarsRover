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
}