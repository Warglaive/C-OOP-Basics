using System;
using System.Collections.Generic;
using System.Text;


public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public override double CalculatePerimeter()
    {
        var perimeter = 2 * (Math.PI * this.Radius);
        return perimeter;
    }

    public override double CalculateArea()
    {
        var area = Math.PI * Math.Pow(this.Radius, 2);
        return area;
    }
    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}

