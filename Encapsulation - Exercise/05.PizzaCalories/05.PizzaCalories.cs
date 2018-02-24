using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        while (input != "END")
        {
            var inputArgs = input.Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries);
            if (inputArgs[0] == "Dough")
            {
                GetDought(inputArgs);
            }
            else
            {
                GetTopping(inputArgs);
            }
            input = Console.ReadLine();
        }
    }

    private static void GetTopping(string[] inputArgs)
    {
        try
        {
            var toppingType = inputArgs[1];
            var topingWeight = decimal.Parse(inputArgs[2]);
            var currentTopping = new Topping(toppingType, topingWeight);
            var totalToppingCalories = currentTopping.CalculateToppingCalories(topingWeight, toppingType);
            Console.WriteLine($"{totalToppingCalories:f2}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
    }

    private static void GetDought(string[] inputArgs)
    {
        try
        {
            string flourType;
            string bakingTechnique;
            decimal weight;
            //
            flourType = inputArgs[1];
            bakingTechnique = inputArgs[2];
            weight = decimal.Parse(inputArgs[3]);
            //
            CalculatePrintTotalCalories(flourType, bakingTechnique, weight);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
    }

    private static void CalculatePrintTotalCalories(string flourType, string bakingTechnique, decimal weight)
    {
        var totalCalories = new Dough(flourType, bakingTechnique, weight);
        Console.WriteLine($"{totalCalories.CalculateTotalCalories(flourType, bakingTechnique, weight):f2}");
    }
}

