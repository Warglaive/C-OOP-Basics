using System;
using System.Collections.Generic;
using System.Text;


public abstract class Harvester
{
    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        if (energyRequirement > 20000)
        {
            throw new ArgumentException("above 20k");
        }
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }
    private string id;
    private double oreOutput;
    private double energyRequirement;

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        set
        {
            if (value < 0)
            {
            }
            else
            {
                energyRequirement = value;
            }
            if (value > 20000)
            {
            }
            else
            {
                energyRequirement = value;
            }
        }
    }

    public double OreOutput
    {
        get { return oreOutput; }
        set
        {
            if (value < 0)
            {
            }
            else
            {
                oreOutput = value;
            }
        }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
}