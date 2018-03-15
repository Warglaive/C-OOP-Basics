using System;
using System.Collections.Generic;
using System.Text;


public class HardTyre : Tyre
{
    public HardTyre(string name, double hardness)
        : base(name, hardness)
    {
        this.Name = "Hard";
    }
}

