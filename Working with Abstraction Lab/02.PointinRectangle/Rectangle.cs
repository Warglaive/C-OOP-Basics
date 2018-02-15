using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    public Point topLeft { get; set; }
    public Point bottomRight { get; set; }

    public Rectangle(int topX, int topY, int bottomX, int bottomY)
    {
        topLeft = new Point(topX, topY);
        bottomRight = new Point(bottomX, bottomY);
    }

    public bool Contains(Point point)
    {
        var contains =
            point.X >= topLeft.X && point.X <= bottomRight.X
            && point.Y >= topLeft.Y && point.Y <= bottomRight.Y;
        return contains;
    }
}