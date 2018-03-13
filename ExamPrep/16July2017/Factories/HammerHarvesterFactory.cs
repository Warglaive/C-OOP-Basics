using System;
using System.Collections.Generic;
using System.Text;


public class HammerHarvesterFactory
{
    public Hammer GenerateHammerHarvester(string id, double oreOutput, double energyRequirement)
    {
        var hammerHarvester = new Hammer(id, oreOutput, energyRequirement);
        return hammerHarvester;
    }
}