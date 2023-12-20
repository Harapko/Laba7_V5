namespace Laba7_V5;

public class TRectangle
{
    private int _x1, _x2, _x3;
    private int _y1, _y2, _y3;

    private List<double> Side = new List<double>{ 0, 0 };
    
    
    public TRectangle(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        _x1 = x1;
        _x2 = x2;
        _x3 = x3;
        _y1 = y1;
        _y2 = y2;
        _y3 = y3;
        Sides();
    }

    

    private void Sides()
    {
        Side[0] = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
        Side[1] = Math.Sqrt(Math.Pow(_x3 - _x1, 2) + Math.Pow(_y3 - _y1, 2));
    }
    
    public double this[int side]
    {
        get
        {
            return Side[side];
        }
        set
        {
            Side[side] = value;
        }
    }

    public double Area()
    {
        Sides();
        return Side[0] * Side[1];
    }

    public double Perimeter()
    {
        Sides();
        return (Side[0] + Side[1]) * 2;
    }

    public override string ToString() =>
        $"First side is {Convert.ToSingle(Side[0])}\nSecond side is {Convert.ToSingle(Side[1])}\nArea is {Convert.ToSingle(Area())}\nPerimeter is {Convert.ToSingle(Perimeter())}";
    
}