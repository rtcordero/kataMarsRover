namespace MarsRoverKataTest;

public class Position
{
    private Coordinate x;
    private Coordinate y;

    public Position(Coordinate coordinateX, Coordinate coordinateY)
    {
        this.x = coordinateX;
        this.y = coordinateY;
    }

    private int GetXValue()
    {
        return x.GetValue();
    }

    private int GetYValue()
    {
        return y.GetValue();
    }

    public override bool Equals(object? obj)
    {
        if (obj is Position position)
        {
            return position.GetXValue() == GetXValue() && position.GetYValue() == GetYValue();
        }

        return false;
    }
}