using System;
using System.Collections.Generic;
using System.Text;


public class FireBender:Bender
{
    private double heatAggression;

    public FireBender(double heatAggression)
    {
        HeatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get { return heatAggression; }
        set { heatAggression = value; }
    }
}

