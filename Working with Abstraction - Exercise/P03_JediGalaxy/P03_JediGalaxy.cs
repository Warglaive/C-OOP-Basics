using System;
using System.Linq;

class P03_JediGalaxy
{
    public static void Main()
    {
        var dimestions = Console.ReadLine()
        .Split(new[] { ' ' }
        , StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
        var rows = dimestions[0];
        var columns = dimestions[1];

        var matrix = new int[rows, columns];

        var value = 0;
        for (var rowIndex = 0; rowIndex < rows; rowIndex++)
        {
            for (var colIndex = 0; colIndex < columns; colIndex++)
            {
                matrix[rowIndex, colIndex] = value++;
            }
        }

        var command = Console.ReadLine();
        long sum = 0;
        while (command != "Let the Force be with you")
        {
            var ivoRowsCols = command.Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int[] evilCoordinates = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var evilRow = evilCoordinates[0];
            var evilCol = evilCoordinates[1];

            while (evilRow >= 0 && evilCol >= 0)
            {
                if (evilRow >= 0
                    && evilRow < matrix.GetLength(0)
                    && evilCol >= 0
                    && evilCol < matrix.GetLength(1))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
            var ivoCurrentRow = ivoRowsCols[0];
            var ivoCurrentCol = ivoRowsCols[1];

            while (ivoCurrentRow >= 0
                && ivoCurrentCol < matrix.GetLength(1))
            {
                if (ivoCurrentRow >= 0
                    && ivoCurrentRow < matrix.GetLength(0)
                    && ivoCurrentCol >= 0
                    && ivoCurrentCol < matrix.GetLength(1))
                {
                    sum += matrix[ivoCurrentRow, ivoCurrentCol];
                }
                ivoCurrentCol++;
                ivoCurrentRow--;
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(sum);
    }
}