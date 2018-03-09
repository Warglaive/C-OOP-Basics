using System;
using System.Collections.Generic;
using System.Text;


public class HardTyre : Tyre
{
    public HardTyre(string name, double hardness, int degradation, double degradation1)
        : base(name, hardness, degradation)
    {
    }
}