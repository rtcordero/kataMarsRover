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

    public int GetXValue()
    {
        return x.GetValue();
    }

    public int GetYValue()
    {
        return y.GetValue();
    }

    public void IncreaseX()
    {
        x = new Coordinate(GetXValue() + 1);
    }

    public void DecreaseX()
    {
        x = new Coordinate(GetXValue() - 1);
    }

    public void IncreaseY()
    {
        y = new Coordinate(GetYValue() + 1);
    }

    public void DecreaseY()
    {
        y = new Coordinate(GetYValue() - 1);
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