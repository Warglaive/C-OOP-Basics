using System;
using System.Collections.Generic;
using System.Text;


public class Harvester : IMiner
{
    public double oreOutput;
    public double energyRequirement;
    public string Id { get; set; }

    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get => energyRequirement;
        set
        {
            if (value > 20000)
            {
                throw new ArgumentException("EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    public double OreOutput
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

