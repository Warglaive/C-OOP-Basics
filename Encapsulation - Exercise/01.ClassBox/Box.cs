using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private decimal lenght;

    private decimal Lenght
    {
        get { return lenght; }
        set { lenght = value; }
    }
    private decimal width;

    private decimal Width
    {
        get { return width; }
        set { width = value; }
    }
    private decimal height;

    private decimal Height
    {
        get { return height; }
        set { height = value; }
    }


    public decimal CalculateLateralSurfaceArea(decimal lenght, decimal width, decimal height)
    {
        var result = 2 * (lenght * height) + 2 * (width * height);
        return result;
    }
    public decimal CalculateVolume(decimal lenght, decimal width, decimal height)
    {

        var result = lenght * width * height;
        return result;
    }
    public decimal CalculateSurfaceArea(decimal lenght, decimal width, decimal height)
    {//2lw + 2lh + 2wh

        var result = 2 * (lenght * width) + 2 * (lenght * height) + 2 * (width * height);
        return result;
    }
}