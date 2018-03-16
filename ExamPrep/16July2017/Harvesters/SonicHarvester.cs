public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energyRequirement,
        int sonicFactor)
        : base(id, oreOutput, energyRequirement/sonicFactor)
    {
        this.Id = id;
        this.SonicFactor = sonicFactor;
         }

    private int SonicFactor { get; }
}