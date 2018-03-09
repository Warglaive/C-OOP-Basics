using System;
using System.Collections.Generic;
using System.Text;


public class WaterBender : Bender
{
    private double waterClarity;

    protected WaterBender(double waterClarity)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity
    {
        get { return waterClarity; }
        set { waterClarity = value; }
    }

}