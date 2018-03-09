using System;
using System.Collections.Generic;
using System.Text;


public class AirBender : Bender
{
    private double aerialIntegrity;

    protected AirBender(double aerialIntegrity)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        set { aerialIntegrity = value; }
    }
}