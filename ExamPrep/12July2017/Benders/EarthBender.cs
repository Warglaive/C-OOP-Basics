using System;
using System.Collections.Generic;
using System.Text;


public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(double groundSaturation)
    {
        this.GroundSaturation = groundSaturation;
    }
    public double GroundSaturation
    {
        get { return groundSaturation; }
        set { groundSaturation = value; }
    }

}

