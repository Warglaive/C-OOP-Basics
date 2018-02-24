using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        while (input != "END")
        {
            try
            {
                string flourType;
                string bakingTechnique;
                decimal weight;
                var name = ReadInput(input, out flourType, out bakingTechnique, out weight);
                CalculatePrintTotalCalories(name, flourType, bakingTechnique, weight);
                input = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }

    private static void CalculatePrintTotalCalories(string name, string flourType, string bakingTechnique, decimal weight)
    {
        var totalCalories = new Dough(name, flourType, bakingTechnique, weight);
        Console.WriteLine($"{totalCalories.CalculateTotalCalories(flourType, bakingTechnique, weight):f2}");
    }

    private static string ReadInput(string input, out string flourType, out string bakingTechnique, out decimal weight)
    {
        var inputArgs = input.Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries);
        var name = inputArgs[0];
        flourType = inputArgs[1];
        bakingTechnique = inputArgs[2];
        weight = decimal.Parse(inputArgs[3]);
        return name;
    }
}

