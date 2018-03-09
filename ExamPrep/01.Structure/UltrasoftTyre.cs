using System;
using System.Collections.Generic;
using System.Text;


public class UltrasoftTyre : Tyre
{
    public UltrasoftTyre(string name, double hardness, int degradation)
        : base(name, hardness, degradation)
    {
        if (degradation < 30)
        {
            throw new ArgumentException("blow up");
        }
    }

    public double Grip { get; set; }
}

