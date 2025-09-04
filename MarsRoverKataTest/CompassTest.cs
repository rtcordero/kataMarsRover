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
}