using System;
using System.Collections.Generic;
using System.Text;


public class Harvester
{
    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected double EnergyRequirement
    {
        get { return energyRequirement; }
        set
        {
            if (value >= 0 && value <= 20000)
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

    private string Id
    {
        get { return id; }
        set { id = value; }
    }
}