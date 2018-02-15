using System;


class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        PrintRow(n);
    }

    public static void PrintRow(int n)
    {
        var spaces = 0;
        var stars = 0;
        for (int i = 1; i <= n * 2 - 1; i++)
        {
            spaces = n - i;
        }
    }
}