using System;


public abstract class Harvester
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

    public double EnergyRequirement
    {
        get => energyRequirement;
        private set
        {
            if (value > 20000 || value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get => oreOutput;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

}

