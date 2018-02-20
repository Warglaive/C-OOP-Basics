using System;


public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split();
        var pricePerDay = decimal.Parse(input[0]);
        var daysCount = int.Parse(input[1]);

        var seasonType =
            Enum.Parse<PriceCalculator.Season>(input[2]);
        if (input.Length <= 3)
        {
            var discountType = PriceCalculator.DiscountType.None;

            var calculate = new PriceCalculator();
            var result = calculate.CalculatePrice(pricePerDay,
                daysCount, seasonType, discountType);
            Console.WriteLine($"{result:f2}");
        }
        else
        {
            var discountType =
               Enum.Parse<PriceCalculator.DiscountType>(input[3]);

            var calculate = new PriceCalculator();
            var result = calculate.CalculatePrice(pricePerDay,
                daysCount, seasonType, discountType);
            Console.WriteLine($"{result:f2}");
        }
    }
}
