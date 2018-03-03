using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        Driver = driver;
        this.Model = "488-Spider/";
        this.GasPedal = "Zadu6avam sA!/";
        this.PressBreak = "Brakes!/";
    }
    public string Model { get; }
    public string PressBreak { get; }
    public string GasPedal { get; }
    public string Driver { get; }
    public override string ToString()
    {
        return $"{this.Model}{this.PressBreak}{this.GasPedal}{this.Driver}";
    }
}