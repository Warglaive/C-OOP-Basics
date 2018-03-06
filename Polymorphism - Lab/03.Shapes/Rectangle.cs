using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    private double Height { get; }
    private double Width { get; }

    public Rectangle(double height, double width)
    {
        this.Width = width;
        this.Height = height;
    }

    public override double CalculatePerimeter()
    {
        var perimeter = 2 * (this.Height + this.Width);
        return perimeter;
    }

    public override double CalculateArea()
    {
        var area = this.Height * this.Width;
        return area;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
