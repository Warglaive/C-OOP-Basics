using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private string name;
    private string flourType;
    private string bakingTechnique;
    private decimal weight;

    public Dough(string name, string flourType
        , string bakingTechnique, decimal weight)
    {
        this.Name = name;
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
        CalculateTotalCalories(flourType, bakingTechnique, weight);
    }

    public decimal Weight
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

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            if (value != "Crispy"
                && value != "Chewy"
                && value != "Homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (value != "White" && value != "Wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal CalculateTotalCalories(string flourType, string bakingTechnique, decimal weight)
    {

        weight *= 2;
        switch (flourType)
        {
            case "White":
                weight *= 1.5m;
                break;
            case "Wholegrain":
                weight *= 1.0m;
                break;
        }
        switch (bakingTechnique)
        {
            case "Crispy":
                weight *= 0.9m;
                break;
            case "Chewy":
                weight *= 1.1m;
                break;
            case "Homemade":
                weight *= 1.0m;
                break;
        }
        return weight;
    }
}

