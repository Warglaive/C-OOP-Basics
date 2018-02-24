using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private decimal weight;

    public Dough(string flourType
        , string bakingTechnique, decimal weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
        CalculateTotalCalories(flourType, bakingTechnique, weight);
    }

    private decimal Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    private string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            if (value.ToLower() != "crispy"
                && value.ToLower() != "chewy"
                && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    private string FlourType
    {
        get { return flourType; }
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    public decimal CalculateTotalCalories(string flourType, string bakingTechnique, decimal weight)
    {

        weight *= 2;
        switch (flourType.ToLower())
        {
            case "white":
                weight *= 1.5m;
                break;
            case "wholegrain":
                weight *= 1.0m;
                break;
        }
        switch (bakingTechnique.ToLower())
        {
            case "crispy":
                weight *= 0.9m;
                break;
            case "chewy":
                weight *= 1.1m;
                break;
            case "homemade":
                weight *= 1.0m;
                break;
        }
        return weight;
    }
}

