using System;
using System.Collections.Generic;
using System.Text;


public class WaterMonument : Monuments
{
    private int waterAffinity;

    public WaterMonument(int waterAffinity)
    {
        this.WaterAffinity = waterAffinity;
    }
    public int WaterAffinity
    {
        get { return waterAffinity; }
        set { waterAffinity = value; }
    }
}