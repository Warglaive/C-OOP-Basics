using System;

public class Rectangle
{
    private string id;
    private double _x2;
    private double _y2;
    private double _x1;
    private double _y1;

    public string Id
    {
        get => id;
        set => id = value;
    }
    public double X2
    {
        get => _x2;
        set => Math.Abs(_x2 = value);
    }

    public double Y2
    {
        get => _y2;
        set => Math.Abs(_y2 = value);
    }

    public double X1
    {
        get => _x1;
        set => Math.Abs(_x1 = value);
    }
    public double Y1
    {
        get => _y1;
        set => Math.Abs(_y1 = value);
    }
    //public Rectangle(string Id, double X2, double Y2, double X1, double Y1)
    //{
    //    id = Id;
    //    _x2 = X2;
    //    _y2 = Y2;
    //    _x1 = X1;
    //    _y1 = Y1;
    //}
}
