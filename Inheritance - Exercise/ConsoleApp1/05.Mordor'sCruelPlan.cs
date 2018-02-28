using System;


public class Program
{
    public static void Main()
    {
        var foodFactory = new FoodFactory();
        var createFood = foodFactory.ReadFood();
        var moodFactory = new MoodFactory();

        var happinessPoints = moodFactory.CalculateHappinessPoints(createFood);
        var currentMood = moodFactory.CalculateMood(happinessPoints);
        Console.WriteLine($"{happinessPoints + Environment.NewLine}" +
                          $"{currentMood}");
    }
}