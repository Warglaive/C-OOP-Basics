using System;
using System.Collections.Generic;
using System.Linq;


public class Dough
{
    private const decimal MinWeight = 1;
    private const decimal MaxWeight = 200;
    private const decimal DefaultMultiplier = 2;

    private Dictionary<string, decimal> validFlourTypes = new Dictionary<string, decimal>
    {
        ["white"] = 1.5m,
        ["wholegrain"] = 1.0m,
    };

    private Dictionary<string, decimal> validBakingTechniques = new Dictionary<string, decimal>
    {
        ["crispy"] = 0.9m,
        ["chewy"] = 1.1m,
        ["homemade"] = 1.0m,
    };

    private decimal weight;
    private string flourType;
    private string bakingTechnique;

    public Dough(string flourType, string bakingTechnique, decimal weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    private decimal FlourMiltiplier => validFlourTypes[this.FlourType];
    private decimal BakingTechniqueMultiplier => validBakingTechniques[this.BakingTechnique];

    public decimal Calories => DefaultMultiplier * this.Weight * FlourMiltiplier * BakingTechniqueMultiplier;



    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
            }
            weight = value;
        }
    }
    public string FlourType
    {
        get { return flourType; }
        //validate
        set
        {
            ValidateTypes(value.ToLower(), validFlourTypes);
            flourType = value.ToLower();
        }
    }
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            ValidateTypes(value.ToLower(), validBakingTechniques);
            bakingTechnique = value.ToLower();
        }
    }
    private static void ValidateTypes(string type, Dictionary<string, decimal> dictionary) //possible bug
    {
        if (!dictionary.Any(f => f.Key == type))
        {
            throw new ArgumentException("Invalid type of dough.");
        }
    }
}