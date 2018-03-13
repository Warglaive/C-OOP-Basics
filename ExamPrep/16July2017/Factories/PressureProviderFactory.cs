using System;
using System.Collections.Generic;
using System.Text;


public class PressureProviderFactory
{
    public Pressure PressureProviderGenerator(string id, double energyOutput)
    {
        var pressureProvider = new Pressure(id, energyOutput);
        return pressureProvider;
    }
}