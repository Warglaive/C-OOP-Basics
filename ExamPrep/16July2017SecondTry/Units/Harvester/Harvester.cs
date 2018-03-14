using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : Unit
{
    private const double MaxEnergyRequirement = 20000;
    private const double MinEnergyRequirement = 0;
    private const double MinOreOutput = 0;

    private double oreOutput;
    private double energyRequirement;


    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get { return oreOutput; }
        private set
        {
            if (value < MinOreOutput)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        private set
        {
            if (value < MinEnergyRequirement || value > MaxEnergyRequirement)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Type} Harvester - {this.Id}"
               + Environment.NewLine
               + $"Ore Output: {this.OreOutput}"
               + Environment.NewLine
               + $"Energy Requirement: {this.EnergyRequirement}";
    }
}