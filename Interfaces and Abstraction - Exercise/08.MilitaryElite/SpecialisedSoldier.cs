using System;
using System.Collections.Generic;
using System.Text;

public class SpecialisedSoldier : ISpecialisedSoldier
{
    private string corps;

    public SpecialisedSoldier(string corps)
    {
        this.Corps = corps;
    }
    public string Corps
    {
        get { return corps; }
        set
        {
            if (value == "Airforces" || value == "Marines")
            {
                corps = value;
            }
            //skip line
        }
    }
}
