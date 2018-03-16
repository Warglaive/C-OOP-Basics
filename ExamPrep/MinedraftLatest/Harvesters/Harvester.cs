using System;

public abstract class Harvester
{
    private const int MaxEnergyRequirement = 20000;

    public string Id { get; protected set; }
    private double oreOutput;
    private double energyRequirement;

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        private set
        {
            if (value < 0 || value > MaxEnergyRequirement)
            {
                throw new ArgumentException("Energy Requirement invalid");
            }
            energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get { return oreOutput; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Ore Output negative");
            }
            oreOutput = value;
        }
    }

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }
}