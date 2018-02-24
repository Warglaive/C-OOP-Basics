using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
    public Topping(string currentTopping, decimal weight)
    {
        this.CurrentTopping = currentTopping;
        this.Weight = weight;
        CalculateToppingCalories(weight, CurrentTopping);
    }
    private string currentTopping;
    private decimal weight;

    public decimal Weight
    {
        get
        {
            return weight;
        }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{currentTopping} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    private string CurrentTopping
    {
        get
        {
            return currentTopping;
        }
        set
        {
            if (value.ToLower() != "meat"
                && value.ToLower() != "veggies"
                && value.ToLower() != "cheese"
                && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            currentTopping = value;
        }
    }

    public decimal CalculateToppingCalories(decimal weight, string toppingModifier)
    {
        weight *= 2;
        switch (toppingModifier)
        {
            case "meat":
                weight *= 1.2m;
                break;
            case "veggies":
                weight *= 0.8m;
                break;
            case "cheese":
                weight *= 1.1m;
                break;
            case "sauce":
                weight *= 0.9m;
                break;
        }
        return weight;
    }
}