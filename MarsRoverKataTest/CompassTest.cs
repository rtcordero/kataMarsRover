using MarsRover;

namespace MarsRoverKataTest;

[TestFixture]
public class CompassTests
{
    [TestCase(Direction.N, Direction.W)]
    [TestCase(Direction.W, Direction.S)]
    [TestCase(Direction.S, Direction.E)]
    [TestCase(Direction.E, Direction.N)]
    public void CompassRotateToLeft(Direction initialDirection, Direction expectedDirection)
    {
        var compass = new Compass(initialDirection);
        compass.RotateLeft();

        Assert.AreEqual(expectedDirection, compass.GetDirection());
    }

    [TestCase(Direction.N, Direction.E)]
    [TestCase(Direction.E, Direction.S)]
    [TestCase(Direction.S, Direction.W)]
    [TestCase(Direction.W, Direction.N)]
    public void CompassRotateToRight(Direction initialDirection, Direction expectedDirection)
    {
        var compass = new Compass(initialDirection);
        compass.RotateRight();

        Assert.AreEqual(expectedDirection, compass.GetDirection());
    }
}