using System;
using System.Collections.Generic;
using System.Text;


public class Hammer : Harvester
{
    public Hammer(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = oreOutput + oreOutput * 2;//200%
        this.EnergyRequirement = energyRequirement * 2;//100%
    }
}