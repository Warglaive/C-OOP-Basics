using System;
using System.Collections.Generic;
using System.Text;


public class PressureProviderFactory
{
    public PressureProvider PressureProviderGenerator(string id, double energyOutput)
    {
        var pressureProvider = new PressureProvider(id, energyOutput);
        return pressureProvider;
    }
}