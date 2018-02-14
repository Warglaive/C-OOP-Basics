using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var NM = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        var numberOfRectangles = NM[0];
        var intersectionChecks = NM[1];
        var n = NM[0];
        for (int i = 0; i < n; i++)
        {
            var currentRectangle = Console.ReadLine()
                .Split()
                .ToList();
            var id = currentRectangle[0];
            var width = int.Parse(currentRectangle[1]);
            var height = int.Parse(currentRectangle[2]);
        }
    }
}