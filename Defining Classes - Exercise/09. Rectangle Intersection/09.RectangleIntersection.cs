using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var rectList = new List<Rectangle>();
        var NM = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        var numberOfRectangles = NM[0];
        var intersectionChecks = NM[1];
        for (var i = 0; i < numberOfRectangles; i++)
        {
            var rectangle = new Rectangle();
            var currentRectangle = Console.ReadLine().
            Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            rectangle.Id = currentRectangle[0];
            rectangle.X2 = Math.Abs(double.Parse(currentRectangle[1]));
            rectangle.Y2 = Math.Abs(double.Parse(currentRectangle[2]));
            rectangle.X1 = Math.Abs(double.Parse(currentRectangle[3]));
            rectangle.Y1 = Math.Abs(double.Parse(currentRectangle[4]));
            rectList.Add(rectangle);
        }
        if (rectList.Count < 2)
        {
            Console.WriteLine("false");
            return;
        }
        for (var i = 0; i < intersectionChecks; i++)
        {
            var idPair = Console.ReadLine().Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            var firstId = rectList.Where(x => x.Id == idPair[0]).ToList();
            var secondId = rectList.Where(x => x.Id == idPair[1]).ToList();
            var A = new Rectangle();
            var B = new Rectangle();
            if (firstId.Count > 0)
            {
                A = firstId[0];
            }

            if (secondId.Count > 0)
            {
                B = secondId[0];
            }
            if (A.X1 <= B.X2
               && A.X2 >= B.X1
               && A.Y1 <= B.Y2
               && A.Y2 >= B.Y1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}