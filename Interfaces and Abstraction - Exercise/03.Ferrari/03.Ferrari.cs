using System;

public class Program
{
    public static void Main()
    {
        var driver = Console.ReadLine();
        var car = new Ferrari(driver);
        Console.WriteLine(car);
    }
}