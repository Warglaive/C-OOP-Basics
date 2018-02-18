using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string carModel;
    private decimal carSpeed;

    public string CarModel
    {
        get => carModel;
        set => carModel = value;
    }

    public decimal CarSpeed
    {
        get => carSpeed;
        set => carSpeed = value;
    }
}
