using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private decimal lenght;
    private decimal width;
    private decimal height;

    public Box(decimal lenght, decimal width, decimal height)
    {
        this.Lenght = lenght;
        this.Width = width;
        Height = height;
    }

    private decimal Height
    {
        get => height;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Height cannot be zero or negative.");
            }
            height = value;
        }
    }

    private decimal Width
    {
        get => this.width;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
            }
            width = value;
        }
    }

    private decimal Lenght
    {
        get => lenght;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Length cannot be zero or negative.");
            }
            lenght = value;
        }
    }

    public decimal CalculateVolume(decimal lenght, decimal width, decimal height)
    {
        var result = lenght * width * height;
        return result;
    }
    public decimal CalculateSurfaceArea(decimal lenght, decimal width, decimal height)
    {
        var result = 2 * (lenght * width) + 2
            * (lenght * height) + 2 * (width * height);
        return result;
    }
    public decimal CalculateLateralSurfaceArea(decimal lenght, decimal width, decimal height)
    {
        var result = 2 * (lenght * height) + 2 * (width * height);
        return result;
    }
}