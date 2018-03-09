using System;
using System.Collections.Generic;
using System.Text;


public class EarthMonument : Monuments
{
    private int earthAffinity;

    public EarthMonument(int earthAffinity)
    {
        this.EarthAffinity = earthAffinity;
    }
    public int EarthAffinity
    {
        get { return earthAffinity; }
        set { earthAffinity = value; }
    }
}