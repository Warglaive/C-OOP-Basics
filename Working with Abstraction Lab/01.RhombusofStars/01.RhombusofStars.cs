using System;


class Program
{
    static void Main()
    {
        var size = int.Parse(Console.ReadLine());
        for (int starCount = 1; starCount <= size; starCount++)
        {
            PrintRow(size, starCount);
        }
        for (int starCount = size-1; starCount > 0; starCount--)
        {
            PrintRow(size, starCount);
        }
    }

    public static void PrintRow(int size, int starCount)
    {
        for (int i = 0; i < size - starCount; i++)
        {
            Console.Write(" ");
        }
        for (int i = 1; i < starCount; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine("*");
    }
}