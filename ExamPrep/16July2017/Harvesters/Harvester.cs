using System;
using System.Collections.Generic;
using System.Text;


public class Harvester : IMiner
{
    private double oreOutput;
    private double energyRequirement;
    public string Id { get; set; }

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    protected double EnergyRequirement
    {
        get => energyRequirement;
        set
        {
            if (value > 20000)
            {
                throw new ArgumentException("Energy above 20k");
            }
            energyRequirement = value;
        }
    }

    protected double OreOutput
    {
        get => oreOutput;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Negative Ore Output");
            }
            oreOutput = value;
        }
    }

}

