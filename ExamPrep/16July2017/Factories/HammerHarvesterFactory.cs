using System;
using System.Collections.Generic;
using System.Text;


public class HammerHarvesterFactory
{
    public HammerHarvester GenerateHammerHarvester(string id, double oreOutput, double energyRequirement)
    {
        var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
        return hammerHarvester;
    }
}