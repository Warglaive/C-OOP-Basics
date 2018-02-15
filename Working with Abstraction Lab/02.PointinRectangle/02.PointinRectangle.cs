using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int pointCount;
        var rectangle = GetInputRectangle(out pointCount);
        Print(pointCount, rectangle);
    }

    private static Rectangle GetInputRectangle(out int pointCount)
    {
        var rectC = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToList();
        var rectangle = new Rectangle(rectC[0], rectC[1], rectC[2], rectC[3]);
        pointCount = int.Parse(Console.ReadLine());
        return rectangle;
    }

    private static void Print(int pointCount, Rectangle rectangle)
    {
        for (int i = 0; i < pointCount; i++)
        {
            var pointCoords = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();
            var point = new Point(pointCoords[0], pointCoords[1]);
            var contains = rectangle.Contains(point);
            Console.WriteLine(contains);
        }
    }
}