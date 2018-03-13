public class HammerHarvesterFactory
{
    public Hammer GenerateHammerHarvester(string id, double oreOutput, double energyRequirement)
    {
        var hammerHarvester = new Hammer(id, oreOutput, energyRequirement);
        return hammerHarvester;
    }
}