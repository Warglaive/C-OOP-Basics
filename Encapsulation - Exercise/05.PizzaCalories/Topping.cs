using System;
using System.Collections.Generic;
using System.Linq;


public class Topping
{

    private const decimal MinWeight = 1;
    private const decimal MaxWeight = 50;
    private const decimal DefaultMultiplier = 2;

    private Dictionary<string, decimal> validToppingTypes = new Dictionary<string, decimal>
    {
        ["meat"] = 1.2m,
        ["veggies"] = 0.8m,
        ["cheese"] = 1.1m,
        ["sauce"] = 0.9m,
    };
    private string type;
    private decimal weight;

    public Topping(string type, decimal weight)
    {
        this.Type = type;
        ValidateWeight(type, weight);
        this.Weight = weight;
    }

    private decimal TypeMultiplier => validToppingTypes[type];

    public decimal calories => DefaultMultiplier * this.Weight * TypeMultiplier;


    private void ValidateWeight(string type, decimal weight)
    {
        if (weight < MinWeight || weight > MaxWeight)
        {
            throw new ArgumentException($"{type} weight should be in the range [{MinWeight}..{MaxWeight}].");
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        { weight = value; }
    }

    public string Type
    {
        get { return type; }
        set
        {
            if (!this.validToppingTypes.Any(t => t.Key == value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value.ToLower();
        }
    }

}