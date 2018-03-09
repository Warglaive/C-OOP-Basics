using System;
using System.Collections.Generic;
using System.Text;


public class AirMonument : Monuments
{
    private int airAffinity;

    public AirMonument(int airAffinity)
    {
        this.AirAffinity = airAffinity;
    }
    public int AirAffinity
    {
        get { return airAffinity; }
        set { airAffinity = value; }
    }
}

