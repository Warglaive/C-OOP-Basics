using System;


public class Program
{
    public static void Main()
    {
        var lenght = decimal.Parse(Console.ReadLine());
        var width = decimal.Parse(Console.ReadLine());
        var height = decimal.Parse(Console.ReadLine());

        var currentBox = new Box();
        var volumeResult = currentBox.CalculateVolume(lenght, width, height);
        var lateralSurfaceAreaResult = currentBox.CalculateLateralSurfaceArea(lenght, width, height);
        var surfaceArea = currentBox.CalculateSurfaceArea(lenght, width, height);
        Console.WriteLine($"Surface Area - {surfaceArea:f2}" +
                          $"{Environment.NewLine}" +
                          $"Lateral Surface Area - {lateralSurfaceAreaResult:f2}" +
                          $"{Environment.NewLine}" +
                          $"Volume - {volumeResult:f2}");
    }
}
