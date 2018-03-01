using System;
using System.Collections.Generic;
using System.Text;

public class MoodFactory
{
    public int CalculateHappinessPoints(string[] food)
    {
        var happinessPoints = 0;
        foreach (var currentFood in food)
        {
            switch (currentFood.ToLower())
            {
                case "cram":
                    happinessPoints += 2;
                    break;
                case "lembas":
                    happinessPoints += 3;
                    break;
                case "apple":
                    happinessPoints += 1;
                    break;
                case "melon":
                    happinessPoints += 1;
                    break;
                case "honeycake":
                    happinessPoints += 5;
                    break;
                case "mushrooms":
                    happinessPoints -= 10;
                    break;
                default:
                    happinessPoints -= 1;
                    break;
            }
        }
        return happinessPoints;
    }

    public string CalculateMood(int happinessPoints)
    {
        var mood = string.Empty;
        if (happinessPoints < -5)
        {
            mood = "Angry";
        }
        else if (happinessPoints >= -5 && happinessPoints <= 0)
        {
            mood = "Sad";
        }
        else if (happinessPoints >= 1 && happinessPoints <= 15)
        {
            mood = "Happy";
        }
        else if (happinessPoints > 15)
        {
            mood = "JavaScript";
        }
        return mood;
    }
}