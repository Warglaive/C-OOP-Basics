public class HarvesterFactory
{
    public HammerHarvester GenerateHammerHarvester(string id,
        double oreOutput, double energyRequirement)
    {
        var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
        return hammerHarvester;
    }

    public SonicHarvester GenerateSonicHarvester(string id,
        double oreOutput, double energyRequirement, int sonicFactor)
    {
        var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        return sonicHarvester;
    }
}