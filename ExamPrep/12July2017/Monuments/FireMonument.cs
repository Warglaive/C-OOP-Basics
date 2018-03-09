using System;
using System.Collections.Generic;
using System.Text;


public class FireMonument : Monuments
{
    private int fireAffinity;

    public FireMonument(int fireAffinity)
    {
        this.FireAffinity = fireAffinity;
    }
    public int FireAffinity
    {
        get { return fireAffinity; }
        set { fireAffinity = value; }
    }

}
