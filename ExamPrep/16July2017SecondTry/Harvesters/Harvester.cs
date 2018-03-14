using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester
{
    private string Id { get; }
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    protected double EnergyRequirement
    {
        get { return energyRequirement; }
        set
        {
            if (value >= 0 || value <= 20000)
            {
                energyRequirement = value;
            }
        }
    }

    protected double OreOutput
    {
        get { return oreOutput; }
        set
        {
            if (value >= 0)
            {
                oreOutput = value;
            }
        }
    }
}