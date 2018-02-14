using System;
using System.Collections.Generic;
using System.Text;


public class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public int CargoWeight
    {
        get => cargoWeight;
        set => cargoWeight = value;
    }

    public string CargoType
    {
        get => cargoType;
        set => cargoType = value;
    }
}